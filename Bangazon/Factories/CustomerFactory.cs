using System;
using System.Collections.Generic;
using System.Data;

namespace Bangazon
{
	public class CustomerFactory
	{
		// Make the factory a singleton to maintain state across all uses
		private static CustomerFactory _instance;
		public static CustomerFactory Instance
		{
			get {
				if (_instance == null) {
					_instance = new CustomerFactory ();
				}
				return _instance;
			}
		}

		// To track the currently active customer - selected by user
		private Customer _activeCustomer = null;
		public Customer ActiveCustomer {
			get {
				return _activeCustomer;
			}
			set{ 
				_activeCustomer = value;
			}
		}

		// Get a single customer
		public Customer get(int IdCustomer)
		{
			BangazonConnection conn = new BangazonConnection ();
			Customer c = null;

			conn.execute (@"select 
				IdCustomer,
				FirstName, 
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
						id = reader.GetInt32(0),
						FirstName = reader [1].ToString(),
						LastName = reader [2].ToString(),
						StreetAddress = reader [3].ToString(),
						City = reader [4].ToString(),
						StateProvince = reader [5].ToString(),
						PostalCode = reader [6].ToString(),
						PhoneNumber = reader [7].ToString()
					};
				}
			});


			return c;
		}

		// Get all customers
		public List<Customer> getAll() 
		{
			BangazonConnection conn = new BangazonConnection ();
			List<Customer> list = new List<Customer> ();

			// Execute the query to retrieve all customers
			conn.execute (@"select 
				IdCustomer,
				FirstName,  
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
							id = reader.GetInt32(0),
							FirstName = reader [1].ToString(),
							LastName = reader [2].ToString(),
							StreetAddress = reader [3].ToString(),
							City = reader [4].ToString(),
							StateProvince = reader [5].ToString(),
							PostalCode = reader [6].ToString(),
							PhoneNumber = reader [7].ToString()
						});
					}
				}
			);


			return list;
		}
	}
}

