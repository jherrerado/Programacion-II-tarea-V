using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.model.dbConnection
{
	public class AccountsConnection
	{
		public SqlConnection GetConnection()
		{
			SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBank"].ConnectionString);
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
			return connection;
		}
	}
}
