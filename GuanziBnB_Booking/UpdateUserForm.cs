using GuanziBnB_Booking.Infra;
using GuanziBnB_Booking.Models.Services;
using GuanziBnB_Booking.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuanziBnB_Booking
{
	public partial class UpdateUserForm : Form
	{
		private int user_id;
		public UpdateUserForm(int user_id)
		{
			InitializeComponent();
			this.user_id = user_id;
		}

		private void UpdateUserForm_Load(object sender, EventArgs e)
		{
			BindData(user_id);
		}

		private void BindData(int user_id)
		{
			string sql = "select * from Booking_Users where User_id=@User_id";
			var param = new SqlParameterBuilder()
						.AddInt("User_id", user_id)
						.Build();
			DataTable dt = new SqlDbHelper("default").Select(sql, param);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("抱歉,找不到要編輯的紀錄!");
				this.Close();
				return;
			}
			var model = new UserService().ToUserVM(dt.Rows[0]);
			txtName.Text = model.Name;
			txtAccount.Text = model.Account;
			txtPassword.Text = model.Password;
			txtPhone.Text = model.Phone;
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string phone = txtPhone.Text;
			string password = txtPassword.Text;
			string account = txtAccount.Text;

			UserVM model = new UserVM
			{
				Password = password,
				Name = name,
				Phone = phone,
				User_id = user_id,
				Account = account
				
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "Password", txtPassword},
				{ "Name", txtName },
				{ "Phone", txtPhone},
				{ "Account", txtAccount}
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new UserService().UpdateUser(model);

				this.DialogResult = DialogResult.OK;

				MessageBox.Show("更新成功","更新會員資料",MessageBoxButtons.OK,MessageBoxIcon.Information);

				if (DialogResult == DialogResult.OK)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("原因: " + ex.Message);
			}
	
		}
	}
	
}
