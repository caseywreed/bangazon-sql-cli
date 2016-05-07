using System;
using Mono.Data.Sqlite;
using Bangazon.Menu;

namespace Bangazon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			CustomerFactory factory = CustomerFactory.Instance;
			MenuSystem menu = new MenuSystem ();
			menu.Start ();
		}
	}
}
