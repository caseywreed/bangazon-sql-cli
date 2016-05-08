using System;

namespace Bangazon
{
	public class Product
	{
		public int IdProduct { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int IdProductType { get; set; }

		public void save()
		{
			string query = string.Format(@"
			insert into Product 
			  (Name, Description, Price, IdProductType)
			values 
			  ('{0}', '{1}', '{2}', 1);
			", 
				this.Name,
				this.Description,
				this.Price
			);

			BangazonConnection conn = new BangazonConnection ();
			conn.insert (query);
		}
	}
}

