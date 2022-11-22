using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanziBnB_Booking.Models.ViewModels
{
	public class PaymentIndexVM
	{
		public int Order_id { get; set; }

		[Range(1,1600000, ErrorMessage = "匯款金額必填")]
		public int Paid_account { get; set; }

		[Required(ErrorMessage = "匯款帳號必填")]
		[StringLength(5,ErrorMessage = "匯款帳號僅須後五碼")]
		public string Remit_account { get; set; }

		[Required(ErrorMessage = "匯款姓名必填")]
		public string Name_remit { get; set; }
		public int Non_Paid { get; set; }

		public int Total_amount { get; set; }
		public DateTime Paid_time { get; set; }
	}
}
