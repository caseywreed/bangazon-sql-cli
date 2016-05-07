using System;
using System.Data;
using Mono.Data.Sqlite;

namespace Bangazon
{
	public class BangazonConnection
	{
		private string _connectionString = "URI=file:/Users/stevebrownlee/dev/github/chortlehoort/Bangazon/Bangazon/bangazon.db";

		public void insert(string query)
		{
			System.Data.IDbConnection dbcon = new SqliteConnection (_connectionString);

			dbcon.Open ();
			IDbCommand dbcmd = dbcon.CreateCommand ();
			dbcon.CreateCommand ();

			dbcmd.CommandText = query;
			dbcmd.ExecuteNonQuery ();

			// clean up
			dbcmd.Dispose ();
			dbcon.Close ();
		}

		public void execute(string query, Action<IDataReader> handler) {			

			System.Data.IDbConnection dbcon = new SqliteConnection (_connectionString);

			dbcon.Open ();
			IDbCommand dbcmd = dbcon.CreateCommand ();
			dbcon.CreateCommand ();

			dbcmd.CommandText = query;
			IDataReader reader = dbcmd.ExecuteReader ();

			handler (reader);

			// clean up
			reader.Dispose ();
			dbcmd.Dispose ();
			dbcon.Close ();
		}

		public BangazonConnection ()
		{
			
		}
	}
}

