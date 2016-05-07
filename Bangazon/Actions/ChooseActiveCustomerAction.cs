using System;
using System.Collections.Generic;

namespace Bangazon
{
	public class ChooseActiveCustomerAction
	{
		public ChooseActiveCustomerAction ()
		{
		}

		public static void ReadInput() {
			CustomerFactory factory = CustomerFactory.Instance;
			List<Customer> customers = factory.getAll ();

			Console.WriteLine ("Select a customer");
			foreach (Customer c in customers) {
				Console.WriteLine ("{0}. {1} {2}", c.id, c.FirstName, c.LastName);
			}

			Console.Write ("> ");
			int choice = Int32.Parse (Console.ReadLine ());
			factory.ActiveCustomer = customers.Find (c => c.id == choice);
			Console.WriteLine (factory.ActiveCustomer.ToString ());
		}
	}
}

