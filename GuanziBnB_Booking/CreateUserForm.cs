using GuanziBnB_Booking.Infra;
using GuanziBnB_Booking.Models.Services;
using GuanziBnB_Booking.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuanziBnB_Booking
{
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			//取得表單資料
			string name = txtName.Text;
			string phone = txtPhone.Text;
			string account = txtAccount.Text;
			string password = txtPassword.Text;


			//繫節UserVM
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name,
				Phone = phone,
			};


			//經VM驗證資料 (僅看格式是否正確)
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount},
				{"Password", txtPassword},
				{"Name", txtName},
				{"Phone", txtPhone},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			//驗證通過就新增會員 (新增時經Service商業驗證)
			try
			{
				new UserService().Create(model);

				this.DialogResult = DialogResult.OK;

				MessageBox.Show("註冊成功!","已註冊完成",MessageBoxButtons.OK,MessageBoxIcon.Information);

				if (DialogResult == DialogResult.OK)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("註冊失敗, 原因: " + ex.Message);
			}
			
		}

		private void CreateUserForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
