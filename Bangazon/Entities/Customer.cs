using System;

namespace Bangazon
{
	public class Customer
	{
		public int id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public string PostalCode { get; set; }
		public string PhoneNumber { get; set; }


		public Customer ()
		{
		}

		public override string ToString ()
		{
			return string.Format ("[Customer: id={0}, FirstName={1}, LastName={2}, StreetAddress={3}, City={4}, StateProvince={5}, PostalCode={6}, PhoneNumber={7}]", id, FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber);
		}
	}
}

