using GuanziBnB_Booking.Infra;
using GuanziBnB_Booking.Models.Services;
using GuanziBnB_Booking.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GuanziBnB_Booking
{
	public partial class CreateReservationForm : Form
	{
		private CartIndexVM[] shoppingCart = null;
		private int user_id;
		public CreateReservationForm(int user_id)
		{
			InitializeComponent();
			chkAddBed.Enabled = false;
			this.user_id = user_id;	
		}

		private void CreateReservationForm_Load(object sender, EventArgs e)
		{
			string msg = "1.入住時間：下午3:00後\r\n2.退房時間：上午11:00\r\n3.民宿無兒童設備及保護措施，不接收12歲以下客人。\r\n4.禁止吸菸，抽菸請至戶外。\r\n5.無電梯，房間都在2樓，不適合年長者入住。\r\n6.個人貴重物品請自行攜帶，如有遺失數不賠償。\r\n7.逾時退房半小時加收300元，以此類推。\r\n8.禁止攀爬門窗，以免發生危險。";
			DialogResult result = MessageBox.Show(msg,"請詳閱入住須知",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if (result == DialogResult.Cancel)
			{
				this.Close();
			}
			lblAvailable1.Text = string.Empty;
			lblAvailable2.Text = string.Empty;
			lblAvailable3.Text = string.Empty;
			lblAvailable4.Text = string.Empty;

			Initrdobtn();
			DisplayCart(user_id);

			
		}

		private void Initrdobtn()
		{
			RadioButton[] controls = { rdo1 , rdo2, rdo3 ,rdo4};
			foreach (var item in controls)
			{
				item.Visible = false;
				item.Checked = false;	
			}
		}

		private void btnSerach_Click(object sender, EventArgs e)
		{
			//chkAddBed.Enabled = false;
			lblAvailable1.Text = string.Empty;
			lblAvailable2.Text = string.Empty;
			lblAvailable3.Text = string.Empty;
			lblAvailable4.Text = string.Empty;
			DateTime endDate = dtpEndDate.Value.Date;
			DateTime startDate = dtpStartDate.Value.Date;
			TimeSpan sevenDays = new TimeSpan(7,0,0,0);

			if (startDate.Date >= endDate.Date)
			{
				MessageBox.Show("入住日期不可等於或晚於退房日期", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (startDate.Date < DateTime.Today)
			{
				MessageBox.Show("入住日期不可早於今日", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (endDate - startDate > sevenDays)
			{
				MessageBox.Show("訂房時間不可超過一星期", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			rdo1.Visible = true;
			rdo2.Visible = true;
			rdo3.Visible = true;
			rdo4.Visible = true;
			radiobtnVisibleFalse();
			FindAvailable();
			

			RadioButton[] controls = { rdo1, rdo2, rdo3, rdo4 };
			foreach (var item in controls)
			{
				item.Checked = false;
			}
			chkAddBed.Enabled = false;
			return;
		}

		private void FindAvailable()
		{
			
			DateTime endDate = dtpEndDate.Value.Date;
			DateTime startDate = dtpStartDate.Value.Date;

			var available = new UserService().GetAvailable(startDate).ToArray();			

			string nonEmpty = "沒空房";
			List<DateTime> search = new List<DateTime>();
			for (DateTime i = startDate; i <= endDate ; i = i.AddDays(1))
			{
				search.Add(i);
			}

			radiobtnVisibleFalse();

			foreach (var item in available)
			{
				if (item.Start_date == search[0] && search.Contains(item.End_date))
				{
					if (item.Room_id == 1)
					{
						lblAvailable1.Text = nonEmpty;
						rdo1.Visible = false;
					}
					else if (item.Room_id == 2)
					{
						lblAvailable2.Text = nonEmpty;
						rdo2.Visible = false;
					}
					else if (item.Room_id == 3)
					{
						lblAvailable3.Text = nonEmpty;
						rdo3.Visible = false;
					}
					else if (item.Room_id == 3)
					{
						lblAvailable4.Text = nonEmpty;
						rdo4.Visible = false;
					}
				}
			}
			RadioButton[] controls = { rdo1, rdo2, rdo3, rdo4 };
			for (int i = 0; i < controls.Length ; i++)
			{
				if (controls[i].Checked != true)
				{
					return;
				}
			}
			return;
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			chkAddBed.Enabled = false;

			//取得購物車訂資訊
			DateTime endDate = dtpEndDate.Value.Date;
			DateTime startDate = dtpStartDate.Value.Date;
			int addBed = chkAddBed.Checked ? 1 : 0;
			int user_id = this.user_id;
			RadioButton[] control = { rdo1, rdo2, rdo3, rdo4 };
			int room_id = 0;
			for (int i = 0; i < control.Length; i++)
			{
				if (control[i].Checked == true)
				{
					room_id = i + 1;
				}
			}
				//繫結
			CartVM model = new CartVM()
			{
				Room_id = room_id,
				Start_date = startDate,
				End_date = endDate,
				AddBed = addBed,
				User_id = user_id,
			};

			//建立購物車資料表資料
			new UserService().CreateCart(model);

			//呈現此會員的購物車
			DisplayCart(user_id);
			chkAddBed.Checked = false;
			chkAddBed.Enabled = false;
			radiobtnVisibleFalse();

			return;
		}

		private void radiobtnVisibleFalse()
		{
			foreach (var item in shoppingCart)
			{
				if (item.Room_id == 1)
				{
					rdo1.Visible = false;
				}
				if (item.Room_id == 2)
				{
					rdo2.Visible = false;
				}
				if (item.Room_id == 3)
				{
					rdo3.Visible = false;
				}
				if (item.Room_id == 4)
				{
					rdo4.Visible = false;
				}
			}
		}

		private void DisplayCart(int user_id)
		{
			shoppingCart = new UserService().GetShoppinCart(user_id).ToArray();
			BindData(shoppingCart);
			decimal totalAmount = Calc(shoppingCart);
			lblTotalAmount.Text = totalAmount.ToString("#,#");
			decimal need_paid = Math.Round((totalAmount / 3), MidpointRounding.AwayFromZero);
			lblNeedPaid.Text = need_paid.ToString("#,#");
		}

		private int Calc(CartIndexVM[] shoppingCart)
		{
			int total = 0;
			foreach (var item in shoppingCart)
			{
				total += item.Room_price;
				if (item.AddBed == "是")
				{
					total += item.AddBed_price;
				}
			};
			return total;
		}

		private void BindData(CartIndexVM[] shoppingcart)
			{
				dataGridView1.DataSource = shoppingcart;
			}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			//取得訂單資料
			var booked = new UserService().GetBooked(user_id).ToArray();
			if (booked.Length == 0)
			{
				MessageBox.Show("尚未選取欲預定時間及房型", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			//取得付款資訊

			string remitName = txtRemitName.Text;
			bool isInt_paid = int.TryParse(txtPaidAmount.Text, out int num_p);
			int paidAccount = num_p;
			string remitAccount = txtRemitAccount.Text;
			int totalAmount = Calc(shoppingCart);
			DateTime paid_time = dtpPaidTime.Value;			
			
			//藉由VM驗證
			//經VM驗證資料 (僅看格式是否正確)
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name_remit" , txtRemitName},
				{"Paid_account", txtPaidAmount},
				{"Remit_account", txtRemitAccount},
			};

			//繫結
			PaymentIndexVM model = new PaymentIndexVM()
			{
				Name_remit = remitName,
				Paid_account = paidAccount,
				Remit_account = remitAccount,
				Total_amount = totalAmount,
				Non_Paid = totalAmount - paidAccount,
				Paid_time = paid_time,
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			txtPaidAmount.Text = paidAccount.ToString("#,#");
			if (txtPaidAmount.Text != lblNeedPaid.Text)
			{
				MessageBox.Show("匯款金額需與需付訂金相同，\r\n若經查不同則取消訂單", "提醒",
								 MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int order_id = new UserService().CreateOrder(user_id);
			new UserService().CreateReservation(booked, user_id, order_id);

			new UserService().CreatePayment(model, order_id);
				
				this.DialogResult = DialogResult.OK;

			MessageBox.Show("訂房成功!", "已完成訂房", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您確定要重新選擇嗎?", "重新選擇",
									MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
									!= DialogResult.OK)
			{
			   return;
			}
			try
			{
				new UserService().Delete(user_id);
			}
			catch (Exception ex)
			{
				MessageBox.Show("原因: " + ex.Message);
			}

			DisplayCart(user_id);
			RadioButton[] control = { rdo1, rdo2, rdo3, rdo4 };
			for (int i = 0; i < control.Length; i++)
			{
				control[i].Checked = false;	
			}
			for (int i = 0; i < control.Length; i++)
			{
				control[i].Visible = true;

			}
			FindAvailable();
			
			this.DialogResult = DialogResult.OK;

			}

		private void CreateReservationForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			new UserService().Delete(user_id);
		}

		private void rdo1_Click(object sender, EventArgs e)
		{
			chkAddBed.Enabled = true;
		}

		private void rdo2_CheckedChanged(object sender, EventArgs e)
		{
			chkAddBed.Enabled = true;
		}

		private void rdo3_CheckedChanged(object sender, EventArgs e)
		{
			chkAddBed.Enabled = true;
		}

		private void rdo4_CheckedChanged(object sender, EventArgs e)
		{
			chkAddBed.Enabled = true;
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			dataGridView1.ClearSelection();
		}
	}
}

