using System;

namespace Bangazon.Actions
{
	public class CreatePaymentOptionAction
	{
		public CreatePaymentOptionAction ()
		{
		}

		public static void ReadInput() {
			var factory = new CustomerFactory();
			var customers = factory.getAll ();

			Console.WriteLine ("Select a customer");
			foreach (Customer c in customers) {
				Console.WriteLine ("{0}. {1} {2}", c.id, c.FirstName, c.LastName);
			}

			Console.Write ("> ");
			int choice = Int32.Parse (Console.ReadLine ());

		}
	}
}

