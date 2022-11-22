using GuanziBnB_Booking.Models.Services;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuanziBnB_Booking
{
	public partial class EditReservationForm : Form
	{
		private int order_id;
		public EditReservationForm(int order_id)
		{
			InitializeComponent();
			this.order_id = order_id;
			lblCancel.Text = String.Empty;
		}

		private void EditReservationForm_Load(object sender, EventArgs e)
		{
			BindData(order_id);
			
		}


		private void BindData(int order_id)
		{
			var model_r = new UserService().GetOrder(order_id).ToArray();
			lblReservationId.Text = order_id.ToString();	
			

			var model_p = new UserService().GetPayment(order_id);
			lblName_remit.Text = model_p.Name_remit;
			lblNonPaid.Text = model_p.Non_Paid.ToString("#,#");
			lblRemit_account.Text = model_p.Remit_account;
			lblPaidTime.Text = model_p.Paid_time.ToString("yyyy/MM/dd");
			lblPaid.Text = model_p.Paid_account.ToString("#,#");

			foreach (var item in model_r)
			{
				if (item.CancelStatus == true)
				{
					lblCancel.Text = "訂單已取消";
					btnUpdate.Visible = false;
				}
			}
			
			dataGridView1.DataSource = model_r;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您確定要取消嗎? \r\n取消後不退回訂金!", "取消預定",
								MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
								!= DialogResult.Yes)
			{
				return;
			}
			try
			{
				new UserService().Update(order_id);

			}
			catch (Exception ex)
			{
				MessageBox.Show("原因: " + ex.Message);
			}

			this.DialogResult = DialogResult.OK;
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			dataGridView1.ClearSelection();
		}
	}
}
