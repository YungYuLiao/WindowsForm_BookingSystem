using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanziBnB_Booking.Models.ViewModels
{
	public class UserIndexVM
	{
		public int User_id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Phone { get; set; }

	}
	public class UserVM
	{
		public int User_id { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "密碼必填")]

		public string Password { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "姓名必填")]
		public string Name { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "電話必填")]
		[Phone(ErrorMessage = "電話格式錯誤，請重新輸入!")]
		public string Phone { get; set; }
	}
}
