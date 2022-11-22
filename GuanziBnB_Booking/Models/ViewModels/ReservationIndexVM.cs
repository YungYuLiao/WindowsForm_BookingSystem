using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanziBnB_Booking.Models.ViewModels
{
	public class ReservationIndexVM
	{
		public int Order_id { get; set; }
		public int Reservation_id { get; set; }
		public string Name { get; set; }
		public string Room_type { get; set; }
		public DateTime Start_date { get; set; }
		public DateTime End_date { get; set; }
		public int AddBed { get; set; }
		public string Create_at { get; set; }
		public bool CancelStatus { get; set; }
	}
	public class ReservationVM
	{
		public int Order_id { get; set; }
		public int Reservation_id { get; set; }
		public string Name { get; set; }
		public string Room_type { get; set; }
		public int Room_Price { get; set; }
		public DateTime Start_date { get; set; }
		public DateTime End_date { get; set; }
		public int AddBed { get; set; }
		public bool CancelStatus { get; set; }
		public int Room_id{ get; set; }
		public int Room_qty { get; internal set; }
	}
}
