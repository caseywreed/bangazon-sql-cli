using System;

namespace Bangazon.Actions
{
	public class CreateCustomerAction
	{
		public CreateCustomerAction ()
		{
		}

		public static void ReadInput() {
			Customer customer = new Customer();

			Console.WriteLine ("Enter customer name");
			string name = Console.ReadLine ();
			char[] del = { ' ' };
			customer.FirstName = name.Split (del)[0];
			customer.LastName = name.Split (del)[1];

			Console.WriteLine ("Enter street address");
			customer.StreetAddress = Console.ReadLine ();

			Console.WriteLine ("Enter city");
			customer.City = Console.ReadLine ();

			Console.WriteLine ("Enter state");
			customer.StateProvince = Console.ReadLine ();

			Console.WriteLine ("Enter postal code");
			customer.PostalCode = Console.ReadLine ();

			Console.WriteLine ("Enter phone number");
			customer.PhoneNumber = Console.ReadLine ();

			Console.WriteLine (customer.ToString ());


		}
	}
}

