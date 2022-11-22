using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuanziBnB_Booking.Infra.Extensions
{
	public static class StringExtensions
	{
		public static int ToInt(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);
			return isInt ? number : defaultValue;
		}
	}
}
