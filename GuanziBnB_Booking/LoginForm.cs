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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void lblRegister_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			var frmRegister = new CreateUserForm();
			frmRegister.Owner = this;

			txtAccount.Text = String.Empty;
			txtPassword.Text = String.Empty;

			frmRegister.Show();
			this.Hide();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM
			{
				Account = txtAccount.Text,
				Password = txtPassword.Text
			};

			//驗證欄位
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "Account", txtAccount },
				{ "Password", txtPassword},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤!");
				return;
			}

			//正確就開啟mainForm
			txtAccount.Text = String.Empty;
			txtPassword.Text = String.Empty;

			//傳userVM給MainForm
			UserVM userVM = new UserService().GetUser(model.Account);
			var frmMain = new MainForm(userVM);
			frmMain.Owner = this;

			frmMain.Show();
			this.Hide();
		}
	}
}
