using System;

namespace Bangazon
{
	public class PaymentOption
	{
		public int IdPaymentOption { get; set; }
		public int IdCustomer { get; set; }
		public string Name { get; set; }
		public string AccountNumber { get; set; }

		public PaymentOption ()
		{
		}

		public void save()
		{
			string query = string.Format(@"
			insert into PaymentOption 
			  (IdCustomer, Name, AccountNumber)
			values 
			  ('{0}', '{1}', '{2}');
			", 
				this.IdCustomer,
				this.Name,
				this.AccountNumber
			);

			BangazonConnection conn = new BangazonConnection ();
			conn.insert (query);
		}
	}
}

