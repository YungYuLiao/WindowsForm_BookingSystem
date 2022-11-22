using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanziBnB_Booking.Models.ViewModels
{
	public class CartIndexVM
	{
		public string Room_type { get; set; }
		public DateTime Start_date { get; set; }
		public DateTime End_date { get; set; }
		public string AddBed { get; set; }
		public string No_of_Date { get; set; }	
		public int Room_price { get; set; }
		public int AddBed_price { get; set; }
		public int Room_id { get; set; }
	}
	public class CartVM
	{
		public int Room_id { get; set; }
		public DateTime Start_date { get; set; }
		public DateTime End_date { get; set; }
		public int AddBed { get; set; }
		public int User_id { get; set; }

	}
}
