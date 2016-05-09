using System;

namespace Bangazon.Actions
{
	public class CreatePaymentOptionAction
	{
		public CreatePaymentOptionAction ()
		{
		}

		public static void ReadInput() {
			Customer currentCustomer = CustomerFactory.Instance.ActiveCustomer;
			PaymentOption opt = new PaymentOption ();

			if (currentCustomer == null) {
				Console.WriteLine ("There must be an active customer first. Press any key to return to main menu.");
			} else {
				Console.WriteLine ("Enter payment type (e.g. AmEx, Visa, Checking)");
				Console.Write ("> ");
				opt.Name = Console.ReadLine ();

				Console.WriteLine ("Enter account number");
				Console.Write ("> ");
				opt.AccountNumber = Console.ReadLine ();

				opt.IdCustomer = currentCustomer.id;
				opt.save ();

				Console.WriteLine ("Payment option added. Press any key to return to main menu.");
			}

			Console.ReadLine ();
		}
	}
}

