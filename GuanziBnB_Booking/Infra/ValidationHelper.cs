using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuanziBnB_Booking.Infra
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			ValidationContext context = new ValidationContext(model, null, null);
			List<ValidationResult> errors = new List<ValidationResult>();

			errorProvider.Clear();
			bool validateAllProperties = true;

			bool isValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
			if (!isValid)
			{
				DisplayErrorByErrorProvider(errors, map, errorProvider);
			}
			return isValid;
		}

		public static void DisplayErrorByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{

			errorProvider.Clear();
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}

		}
	}
}
