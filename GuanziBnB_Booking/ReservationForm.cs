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
	public partial class ReservationForm : Form
	{
		private ReservationIndexVM[] order = null;
		private ReservationIndexVM[] reservations = null;
		private int user_id;
		private PaymentIndexVM [] payment = null;
		
		public ReservationForm(int user_id)
		{
			InitializeComponent();
			
			this.user_id = user_id;

			
			//呈現此使用者的預定 (IndexVM)
			DisplayReservation(user_id);
		}

		private void DisplayReservation(int user_id)
		{
			order = new UserService().Get(user_id).ToArray();
			reservations = new UserService().GetReservations(user_id).ToArray();
			payment = new UserService().GetPaymentIndex(user_id).ToArray();
			BindData(order);
		}

		private void BindData(ReservationIndexVM[] reservation)
		{
			dtgReservation.DataSource = reservation;
		}

		private void dtgReservation_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			// 使用者點到的那一筆記錄
			ReservationIndexVM row = this.reservations[rowIndx];

			// 使用者點到的那一筆記錄的id值
			int order_id = row.Order_id;

			// 把 Reservation_id傳給編輯表單的建構函數
			var frm = new EditReservationForm(order_id);

			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayReservation(user_id);
			}
		}

		private void ReservationForm_Load(object sender, EventArgs e)
		{

			string info = $"親愛的房客您好，以下是您的預定清單，\r\n點選清單可見詳情，餘款當日付現或線上轉帳即可。";
			lblInfo.Text = info;
		}

		private void dtgReservation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
			e.RowBounds.Location.Y,
			dtgReservation.RowHeadersWidth - 4,
			e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics,
			(e.RowIndex + 1).ToString(),
			dtgReservation.RowHeadersDefaultCellStyle.Font,
			rectangle,
			dtgReservation.RowHeadersDefaultCellStyle.ForeColor,
			TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
		}
	}
}
