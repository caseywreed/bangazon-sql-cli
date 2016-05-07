using System;
using System.Collections.Generic;

namespace Bangazon.Actions
{
	public class CreateCustomerAction
	{
		public CreateCustomerAction ()
		{
		}

		public static void ReadInput() {
			Customer customer = new Customer();

			Console.WriteLine ("Enter customer first name");
			customer.FirstName = Console.ReadLine();

			Console.WriteLine ("Enter customer last name");
			customer.LastName = Console.ReadLine();

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

			customer.save ();

			CustomerFactory f = new CustomerFactory ();
			List<Customer> customers = f.getAll ();

			foreach (Customer c in customers) {
				Console.WriteLine ("{0} {1}", c.FirstName, c.LastName);
			}


		}
	}
}

