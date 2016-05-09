using System;

namespace Bangazon
{
	public class CustomerOrder
	{
		public string OrderNumber { get; set; }
		public string DateCreated { get; set; }
		public int IdCustomer { get; set; }
		public int IdPaymentOption { get; set; }
		public string ShippingMethod { get; set; }
		public bool Complete { get; set; }

		public CustomerOrder ()
		{
		}

		public void save()
		{
			string query = string.Format(@"
			insert into CustomerOrder
			  (OrderNumber, DateCreated, IdCustomer, IdPaymentOption, ShippingMethod, Complete)
			values 
			  ('{0}', '{1}', {2}, {3}, '{4}', {5});
			", 
				this.OrderNumber,
				this.DateCreated,
				this.IdCustomer,
				this.IdPaymentOption,
				this.ShippingMethod,
				this.Complete
			);

			BangazonConnection conn = new BangazonConnection ();
			conn.insert (query);
		}
	}
}

