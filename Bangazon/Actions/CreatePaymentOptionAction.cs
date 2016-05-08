using System;

namespace Bangazon.Actions
{
	public class CreatePaymentOptionAction
	{
		public CreatePaymentOptionAction ()
		{
		}

		public static void ReadInput() {
			CustomerFactory factory = CustomerFactory.Instance;
			Customer c = factory.ActiveCustomer;
			PaymentOption opt = new PaymentOption ();

			if (c == null) {
				Console.WriteLine ("There must be an active customer first. Press any key to return to main menu.");
			} else {
				Console.WriteLine ("Enter payment type (e.g. AmEx, Visa, Checking)");
				Console.Write ("> ");
				opt.Name = Console.ReadLine ();

				Console.WriteLine ("Enter account number");
				Console.Write ("> ");
				opt.AccountNumber = Console.ReadLine ();

				opt.IdCustomer = c.id;
				opt.save ();

				Console.WriteLine ("Payment option added. Press any key to return to main menu.");
			}

			Console.ReadLine ();
		}
	}
}

