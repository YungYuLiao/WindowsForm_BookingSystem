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
	public partial class MainForm : Form
	{
		private string name;
		private int user_id;
		int image = 0;
		public MainForm(UserVM model)
		{
			InitializeComponent();
			name = model.Name;
			user_id = model.User_id;
			lblGreet.Text = $" {name} 您好!";
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?", "登出", 
				                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void btnBook_Click(object sender, EventArgs e)
		{
			var creatfrm = new CreateReservationForm(user_id);
			creatfrm.MdiParent = this.MdiParent;
			creatfrm.Show();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var creatfrm = new ReservationForm(user_id);
			creatfrm.MdiParent = this.MdiParent;
			creatfrm.Show();

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			new UserService().Delete(user_id);
		}

		private void goNext(object sender, EventArgs e)
		{
			image++;
			if (image > 5)
			{
				image = 1;
			}
			ChangeImage(image);
		}

		private void goBack(object sender, EventArgs e)
		{
			image--;
			if (image < 1)
			{
				image = 5;
			}
			ChangeImage(image);
		}
		private void ChangeImage(int num) 
		{ 
			switch(num)
			{
				case 1:
					pictureBox1.Image = Properties.Resources.標準雙人房01;
					lblRoomType.Text = "標準雙人房。為兩張單人床房型。\r\n包含早餐。容納人數2人，\r\n可加至3人。";
					break;
				case 2:
					pictureBox1.Image = Properties.Resources.標準雙人房02;
					lblRoomType.Text = "標準雙人房。為兩張單人床房型。\r\n包含早餐。容納人數2人，\r\n可加至3人。";
					break;
				case 3:
					pictureBox1.Image = Properties.Resources.雙床雙人房01;
					lblRoomType.Text = "雙床雙人房。為兩單人床房型。\r\n包含早餐。容納人數2人，\r\n可加至3人。";
					break;
				case 4:
					pictureBox1.Image = Properties.Resources.雙床雙人房02;
					lblRoomType.Text = "雙床雙人房。為兩單人床房型。\r\n包含早餐。容納人數2人，\r\n可加至3人。";
					break;
				case 5:
					pictureBox1.Image = Properties.Resources.陽台 ;
					lblRoomType.Text = "每間房皆有獨立陽台。天氣好時，\r\n夜晚可見嘉義市區夜景\r\n以及銀河星空，讓人輕鬆享受\r\n悠然的度假夜晚。";
					break;
			}

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			ChangeImage(5);
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			var frm = new UpdateUserForm(user_id);
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
	}
}
