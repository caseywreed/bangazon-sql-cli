using System;
using System.Collections.Generic;
using System.Data;

namespace Bangazon
{
	public class CustomerFactory
	{
		public CustomerFactory ()
		{
		}

		public Customer get(int IdCustomer)
		{
			BangazonConnection conn = new BangazonConnection ();
			Customer c = null;

			conn.execute (@"select FirstName, 
				LastName, 
				StreetAddress, 
				City, 
				StateProvince, 
				PostalCode, 
				PhoneNumber 
				from customers
				where IdCustomer = " + IdCustomer, (IDataReader reader) => {
				while (reader.Read ())
				{
					c = new Customer {
						FirstName = reader [0].ToString(),
						LastName = reader [1].ToString(),
						StreetAddress = reader [2].ToString(),
						City = reader [3].ToString(),
						StateProvince = reader [4].ToString(),
						PostalCode = reader [5].ToString(),
						PhoneNumber = reader [6].ToString()
					};
				}
			});


			return c;
		}



		public List<Customer> getAll() 
		{
			BangazonConnection conn = new BangazonConnection ();
			List<Customer> list = new List<Customer> ();

			// Execute the query to retrieve all customers
			conn.execute (@"select FirstName, 
				LastName, 
				StreetAddress, 
				City, 
				StateProvince, 
				PostalCode, 
				PhoneNumber 
				from customer", 
				(IDataReader reader) => {
					while (reader.Read ())
					{
						list.Add(new Customer {
							FirstName = reader [0].ToString(),
							LastName = reader [1].ToString(),
							StreetAddress = reader [2].ToString(),
							City = reader [3].ToString(),
							StateProvince = reader [4].ToString(),
							PostalCode = reader [5].ToString(),
							PhoneNumber = reader [6].ToString()
						});
					}
				}
			);


			return list;
		}
	}
}

