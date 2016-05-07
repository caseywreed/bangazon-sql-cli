using System;
using System.Text;
using System.Collections.Generic;
using Bangazon.Actions;

namespace Bangazon.Menu
{
	public class MenuSystem
	{
		private struct MenuItem {
			public string prompt;
			public delegate void MenuAction ();
			public MenuAction Action;
		};

		private Dictionary<int, MenuItem> _MenuItems = new Dictionary<int, MenuItem>();
		private bool done = false;

		private void MarkDone()
		{
			done = true;
		}

		public MenuSystem()
		{
			_MenuItems.Add (1, new MenuItem (){
				prompt = "Create an account",
				Action = CreateCustomerAction.ReadInput
			});

			_MenuItems.Add (2, new MenuItem (){
				prompt = "Create a payment option",
				Action = CreatePaymentOptionAction.ReadInput
			});
					
			_MenuItems.Add (3, new MenuItem (){
				prompt = "Order product",
				Action = OrderProductAction.ReadInput
			});

			_MenuItems.Add (4, new MenuItem (){
				prompt = "Leave Bangazon!",
				Action = MarkDone
			});


//			_MenuItems.Add (3, "Order a product");
//			_MenuItems.Add (4, "Complete an order");
//			_MenuItems.Add (5, "See product popularity");
//			_MenuItems.Add (6, "Leave Bangazon!");
		}

		public void Start()
		{
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ForegroundColor = ConsoleColor.Black;

			while (!done) 
			{
				ShowMainMenu ();
			}
		}

		public void ShowMainMenu ()
		{
			Console.Clear ();

			string border = "*********************************************************";
			StringBuilder mainMenu = new StringBuilder ();
			mainMenu.AppendLine ("\n");
			mainMenu.AppendLine (border);
			mainMenu.AppendLine ("**  Welcome to Bangazon! Command Line Ordering System  **");
			mainMenu.AppendLine (border);

			foreach (KeyValuePair<int, MenuItem> item in _MenuItems) {
				mainMenu.AppendLine (string.Format("{0}. {1}", item.Key, item.Value.prompt));
			}

			Console.WriteLine (mainMenu);
			Console.Write ("> ");

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);

			// Based on their choice, execute the appropriate action
			MenuItem menuItem;
			_MenuItems.TryGetValue (choice, out menuItem);
			menuItem.Action ();
		}
	}
}

