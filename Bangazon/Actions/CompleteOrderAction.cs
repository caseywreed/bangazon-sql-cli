using System;
using System.Collections.Generic;

namespace Bangazon
{
	public class CompleteOrderAction
	{
		public CompleteOrderAction ()
		{
		}

		public static void ReadInput() {
			Customer currentCustomer = CustomerFactory.Instance.ActiveCustomer;
			List<Product> cart = ProductFactory.Instance.ShoppingCart;


			if (currentCustomer == null) {
				Console.WriteLine ("There must be an active customer first. Press any key to return to main menu.");
				Console.ReadLine ();
			} else if (cart.Count == 0) {
				Console.WriteLine ("Current customer has no product in the shopping cart. Press any key to return to main menu.");
				Console.ReadLine ();
			}else {
				

			}
		}
	}
}

