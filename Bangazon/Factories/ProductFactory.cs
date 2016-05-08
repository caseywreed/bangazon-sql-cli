using System;
using System.Collections.Generic;
using System.Data;

namespace Bangazon
{
	public class ProductFactory
	{
		// Make the factory a singleton to maintain state across all uses
		private static ProductFactory _instance;
		public static ProductFactory Instance
		{
			get {
				if (_instance == null) {
					_instance = new ProductFactory ();
				}
				return _instance;
			}
		}

		// To track the currently active customer - selected by user
		public List<Product> ShoppingCart = new List<Product>();

		// Get all customers
		public List<Product> getAll() 
		{
			BangazonConnection conn = new BangazonConnection ();
			List<Product> list = new List<Product> ();

			// Execute the query to retrieve all customers
			conn.execute (@"select 
				IdProduct,
				Name,  
				Description, 
				Price, 
				IdProductType 
				from Product", 
				(IDataReader reader) => {
					while (reader.Read ())
					{
						list.Add(new Product {
							IdProduct = reader.GetInt32(0),
							Name = reader [1].ToString(),
							Description = reader [2].ToString(),
							Price = reader.GetDouble(3),
							IdProductType = reader.GetInt32(4)
						});
					}
				}
			);


			return list;
		}
	}
}

