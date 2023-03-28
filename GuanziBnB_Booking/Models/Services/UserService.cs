using GuanziBnB_Booking.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuanziBnB_Booking.Models.Services
{
	public class UserService
	{
		public IEnumerable<ReservationIndexVM> Get(int user_id)
		{
			string sql = @"Select  Order_id, Start_date,　End_date, CancelStatus, Create_at from Reservation r 
                           join Booking_Users u on r.User_id = u.User_id
                           where (r.User_id = @User_id)
                           group by Order_id, Start_date,　End_date, CancelStatus, Create_at
                           order by Start_date";

			var dbHelper = new SqlDbHelper("default");
			var param = new SqlParameterBuilder().AddInt("User_id", user_id).Build();
			return dbHelper.Select(sql, param)
						   .AsEnumerable()
						   .Select(row => ParseToIndexVM(row));
		}
		private ReservationIndexVM ParseToIndexVM(DataRow row)
		{
			return new ReservationIndexVM()
			{

				Order_id = row.Field<int>("Order_id"),
				Start_date = row.Field<DateTime>("Start_date"),
				End_date = row.Field<DateTime>("End_date"),
				Create_at = row.Field<DateTime>("Create_at").ToString("yyyy/MM/dd HH:mm:ss"),
				CancelStatus = row.Field<bool>("CancelStatus")
			};
		}

		public void Create(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"Insert into Booking_Users(Name,Account,Password,Phone)
                           Values(@Name,@Account,@Password,@Phone);";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNVarchar("Phone",25, model.Phone)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(string account)
		{
			string sql = @"Select Count(*) as count from Booking_Users Where Account = @Account";

			var param = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, param);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool Authenticate(LoginVM model)
		{
			var user = GetUser(model.Account);
			if (user == null) return false;

			return (user.Password == model.Password);
		}

		public UserVM GetUser(string account)
		{
			string sql = "Select * from Booking_Users where Account = @Account";
			var param = new SqlParameterBuilder().AddNVarchar("Account", 50, account).Build();
			var dbHelper = new SqlDbHelper("default");

			DataTable dt = dbHelper.Select(sql, param);
			if (dt.Rows.Count == 0) return null;

			return this.ToUserVM(dt.Rows[0]);
		}

		public UserVM ToUserVM(DataRow dataRow)
		{
			return new UserVM()
			{
				User_id = dataRow.Field<int>("User_id"),
				Account = dataRow.Field<string>("Account"),
				Name = dataRow.Field<string>("Name"),
				Password = dataRow.Field<string>("Password"),
				Phone = dataRow.Field<string>("Phone")
			};
		}

		public ReservationVM ToReservationVM_booked(DataRow row)
		{
			return new ReservationVM()
			{
				Start_date = row.Field<DateTime>("Start_date"),
				End_date = row.Field<DateTime>("End_date"),
				AddBed = row.Field<int>("AddBed"),
				Room_id = row.Field<int>("Room_id"),		
			};
		}

		public ReservationVM GetReservation(int reservation_id)
		{
			string sql = @"Select * from Reservation r 
                           join Booking_Users u on r.User_id = u.User_id
                           join Room on r.Room_id = Room.Room_id
                           join Room_Detail rd on Room.Room_type_id = rd.Room_type_id 
                           where (r.Reservation_id = @Reservation_id)";

			var param = new SqlParameterBuilder()
						.AddInt("Reservation_id", reservation_id)
						.Build();
			DataTable dt = new SqlDbHelper("default").Select(sql, param);

			if (dt.Rows.Count == 0) return null;

			return this.ToReservationVM(dt.Rows[0]);
		}

		private ReservationVM ToReservationVM(DataRow row)
		{
			return new ReservationVM
			{
				Reservation_id = row.Field<int>("Reservation_id"),
				Start_date = row.Field<DateTime>("Start_date"),
				End_date = row.Field<DateTime>("End_date"),
				AddBed = row.Field<int>("AddBed"),
				Room_id = row.Field<int>("Room_id"),
				Name = row.Field<string>("Name"),
				Room_type = row.Field<string>("Room_type"),
				CancelStatus = row.Field<bool>("CancelStatus")
			};	
		}

		public PaymentIndexVM GetPayment(int order_id)
		{
			string sql = @"Select * from [Order] o join Payment p on o.Order_id = p.Order_id
                           where o.Order_id = @Order_id";
			var param = new SqlParameterBuilder()
						.AddInt("Order_id", order_id)
						.Build();
			DataTable dt = new SqlDbHelper("default").Select(sql, param);

			if (dt.Rows.Count == 0) return null;

			return this.ToPaymentIndexVM(dt.Rows[0]);
		}

		private PaymentIndexVM ToPaymentIndexVM(DataRow row)
		{
			return new PaymentIndexVM
			{
				Non_Paid = row.Field<int>("Total_amount")- row.Field<int>("Paid_account"),
				Remit_account = row.Field<string>("Remit_account"),
				Name_remit = row.Field<string>("Name_remit"),
				Paid_time = row.Field<DateTime>("Paid_time"),
				Paid_account = row.Field<int>("Paid_account")
			};
		}

		public void Update(int order_id)
		{
			string sql = "Update Reservation set CancelStatus = 1 Where Order_id = @Order_id";
			var param = new SqlParameterBuilder()
						.AddInt("Order_id", order_id)
						.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, param);
		}

		public IEnumerable<ReservationVM> GetAvailable(DateTime startDate)
		{
			string sql = @"Select * from Reservation where Start_date = @Start_date And CancelStatus = 0";
			var param = new SqlParameterBuilder()
						.AddDateTime("Start_date", startDate)
						.Build();
			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, param)
						   .AsEnumerable()
						   .Select(row => ParseToReservationVM(row));
		}

		private ReservationVM ParseToReservationVM(DataRow row)
		{
			return new ReservationVM()
			{
				Reservation_id = row.Field<int>("Reservation_id"),
				Start_date = row.Field<DateTime>("Start_date"),
				End_date = row.Field<DateTime>("End_date"),
				AddBed = row.Field<int>("AddBed"),
				Room_id = row.Field<int>("Room_id"),			
			};
			
		}

		public void CreatePayment(PaymentIndexVM model, int order)
		{

			string sql = @"Insert into Payment (Order_id ,Name_remit,Total_amount,Remit_account,Paid_account,Paid_time) 
                          Values (@Order_id,@Name_remit,@Total_amount, @Remit_account,@Paid_account,@Paid_time);";

			var param = new SqlParameterBuilder()
				.AddInt("Order_id", order)
				.AddNVarchar("Name_remit", 50, model.Name_remit)
				.AddInt("Total_amount", model.Total_amount)
				.AddNVarchar("Remit_account", 50, model.Remit_account)
				.AddInt("Paid_account", model.Paid_account)
				.AddDateTime("Paid_time",model.Paid_time)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, param);
		}

		public void CreateCart(CartVM  model)
		{
			string sql = @"Insert into Cart(Room_id, User_id, Start_date,End_date,AddBed) 
                           Values (@Room_id, @User_id, @Start_date, @End_date, @AddBed)";

				var param = new SqlParameterBuilder()
							.AddInt("User_id", model.User_id)
							.AddDateTime("Start_date", model.Start_date)
							.AddDateTime("End_date", model.End_date)
							.AddInt("AddBed", model.AddBed)
							.AddInt("Room_id", model.Room_id)
							.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, param);
			
		}

		public IEnumerable<CartIndexVM> GetShoppinCart(int user_id)
		{
			string sql = @"Select * from Cart c
                           join Room r　on c.Room_id = r.Room_id
                           join Room_Detail rd on r.Room_type_id = rd.Room_type_id
                           where User_id = @User_id
                           order by Start_date";

			var dbHelper = new SqlDbHelper("default");
			var param = new SqlParameterBuilder().AddInt("User_id", user_id).Build();
			return dbHelper.Select(sql, param)
						   .AsEnumerable()
						   .Select(row => ParseToCartIndexVM(row));
		}

		private CartIndexVM ParseToCartIndexVM(DataRow row)
		{
			return new CartIndexVM()
			{
				AddBed = row.Field<int>("AddBed") == 0 ? "否" : "是",
				End_date = row.Field<DateTime>("End_date"),
				Start_date = row.Field<DateTime>("Start_date"),
				Room_type = row.Field<string>("Room_type"),
				No_of_Date = (row.Field<DateTime>("End_date") - row.Field<DateTime>("Start_date")).ToString("dd"),
				Room_price = row.Field<int>("Room_price"),
				AddBed_price = row.Field<int>("AddBed_price"),
				Room_id = row.Field<int>("Room_id")
			};
		}

		public void Delete(int user_id)
		{
			string sql = "Delete from Cart where User_id = @user_id";
			var param = new SqlParameterBuilder()
						.AddInt("User_id", user_id)
						.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, param);
		}

		public IEnumerable<ReservationVM> GetBooked(int user_id)
		{
			string sql = @"Select * from Cart c where User_id = @User_id";

			var dbHelper = new SqlDbHelper("default");
			var param = new SqlParameterBuilder().AddInt("User_id", user_id).Build();
			return dbHelper.Select(sql, param)
						   .AsEnumerable()
						   .Select(row => ToReservationVM_booked(row));

		}

		public void CreateReservation(ReservationVM [] booked, int user_id, int order_id)
		{
			string order_createTime = "Select Create_time from [Order] Where Order_id = @Order_id";
			var parameters = new SqlParameterBuilder().AddInt("Order_id", order_id).Build();			
			DataTable dt = new SqlDbHelper("default").Select(order_createTime, parameters);

			DateTime create_time = dt.Rows[0].Field<DateTime>("Create_time");

			string sql = @"Insert into Reservation(Order_id ,Room_id, User_id, Start_date,End_date,AddBed, Create_at) 
                           Values (@Order_id,@Room_id, @User_id, @Start_date, @End_date, @AddBed, @Create_at)";
			foreach (var item in booked)
			{
				var param = new SqlParameterBuilder()
					        .AddInt("Order_id",order_id)
							.AddInt("User_id", user_id)
							.AddDateTime("Start_date", item.Start_date)
							.AddDateTime("End_date", item.End_date)
							.AddInt("AddBed", item.AddBed)
							.AddInt("Room_id", item.Room_id)
							.AddDateTime("Create_at", create_time)
							.Build();
				new SqlDbHelper("default").ExecuteNonQuery(sql, param);
			}		
		}

		public IEnumerable<PaymentIndexVM> GetPaymentIndex(int user_id)
		{
			string sql = @"Select * from Payment p
                           join [Order] o on o.Order_id =  p.Order_id
                           where UserId = @UserId";
			var param = new SqlParameterBuilder()
						.AddInt("UserId", user_id)
						.Build();

			var dbHelper = new SqlDbHelper("default");

			return  dbHelper.Select(sql, param)
			       .AsEnumerable()
			       .Select(row => ParseToPaymentIndexVM(row));
		}

		private PaymentIndexVM ParseToPaymentIndexVM(DataRow row)
		{
			return new PaymentIndexVM
			{
				Non_Paid = row.Field<int>("Total_amount") - row.Field<int>("Paid_account"),
				Order_id = row.Field<int>("Order_id")
			};
		}

		public int CreateOrder(int user_id)
		{
			string sqldidentity = @"Insert into [Order](UserId) Values (@UserId);
                                    SELECT IDENT_CURRENT ('Order') as Current_Identity;";
			var param = new SqlParameterBuilder().AddInt("UserId", user_id).Build();
			DataTable dt = new SqlDbHelper("default").Select(sqldidentity, param);
			int order_id = Convert.ToInt32(dt.Rows[0]["Current_Identity"]);
			return order_id;
		}

		public  IEnumerable<ReservationVM> GetOrder(int order_id)
		{
			string sql = @"Select * from Reservation r 
                          join [Order] o on r.Order_id = o.Order_id 
                          join Booking_Users u on r.User_id = u.User_id
                          join Room on r.Room_id = Room.Room_id
                          join Room_Detail rd on Room.Room_type_id = rd.Room_type_id 
                          where r.Order_id = @Order_id
                          order by Start_date";
			var param = new SqlParameterBuilder()
						.AddInt("Order_id", order_id)
						.Build();

			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, param)
				   .AsEnumerable()
				   .Select(row => ToReservationVM(row));
		}

		public IEnumerable<ReservationIndexVM> GetReservations(int user_id)
		{
			string sql = @"Select * from Reservation r 
                          join Booking_Users u on r.User_id = u.User_id
                          where (r.User_id = @User_id)";

			var dbHelper = new SqlDbHelper("default");
			var param = new SqlParameterBuilder().AddInt("User_id", user_id).Build();
			return dbHelper.Select(sql, param)
						   .AsEnumerable()
						   .Select(row => ToIndexVM(row));
		}

		private ReservationIndexVM ToIndexVM(DataRow row)
		{
			return new ReservationIndexVM()
			{
				Reservation_id = row.Field<int>("Reservation_id"),
				Order_id = row.Field<int>("Order_id"),
				Name = row.Field<string>("Name"),
				Start_date = row.Field<DateTime>("Start_date"),
				End_date = row.Field<DateTime>("End_date"),
				Create_at = row.Field<DateTime>("Create_at").ToString("yyyy/MM/dd HH:mm:ss"),
				CancelStatus = row.Field<bool>("CancelStatus")
			};
		}

		public void UpdateUser(UserVM model)
		{
			string sql = @"Update Booking_Users set Account = @Account, Name =@Name ,Password = @Password,Phone=@Phone
			               where User_id = @User_id";
			var param = new SqlParameterBuilder()
				        .AddNVarchar("Account", 50, model.Account)
						.AddNVarchar("Name", 50, model.Name)
						.AddNVarchar("Phone", 25, model.Phone)
						.AddNVarchar("Password", 50, model.Password)
						.AddInt("User_id", model.User_id)
						.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, param);
		}
	}
}
