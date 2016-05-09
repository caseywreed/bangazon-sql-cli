using System;
using System.Collections.Generic;

namespace Bangazon
{
	public class OrderProductAction
	{

		public OrderProductAction ()
		{
		}

		public static void ReadInput() {
			Customer currentCustomer = CustomerFactory.Instance.ActiveCustomer;
			List<Product> products = ProductFactory.Instance.getAll ();
			bool DoneOrdering = false;

			if (currentCustomer == null) {
				Console.WriteLine ("There must be an active customer first. Press any key to return to main menu.");
				Console.ReadLine ();
			} else {
				while (!DoneOrdering) {
					Console.WriteLine ("Select a product");
					foreach (Product currentProduct in products) {
						Console.WriteLine ("{0}. {1} - {2}", currentProduct.IdProduct, currentProduct.Name, currentProduct.Description);
					}
					Console.WriteLine ("{0}. Done adding products", products.Count + 1);

					Console.Write ("> ");
					int choice = Int32.Parse (Console.ReadLine ());

					if (choice != products.Count + 1) {
						ProductFactory.Instance.ShoppingCart.Add (products.Find (c => c.IdProduct == choice));
					} else {
						DoneOrdering = true;
					}

				}
			}
		}
	}
}

