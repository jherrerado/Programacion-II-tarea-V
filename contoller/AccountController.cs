using Bank.model.dbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank.contoller
{
	public class AccountController
	{
		AccountsConnection connection = new AccountsConnection();

		public DataTable GetAccounts()
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SP_SHOWACCOUNTSTABLE", connection.GetConnection());
			dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);
			return dataTable;
		}

		public void SetNewAccounts(int account, string accountName, string type, double amount)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter($"SP_ADDNEWACCOUTNSVALUE", connection.GetConnection());
			dataAdapter.SelectCommand.CommandType=CommandType.StoredProcedure;
			dataAdapter.SelectCommand.Parameters.AddWithValue("@cuenta", account);
			dataAdapter.SelectCommand.Parameters.AddWithValue("@nombreCuenta", accountName);

			switch (type)
			{
				case "Debito":
					dataAdapter.SelectCommand.Parameters.AddWithValue("@debito", amount); 
					dataAdapter.SelectCommand.Parameters.AddWithValue("@credito", 0); 
					break;
				case "Credito":
					dataAdapter.SelectCommand.Parameters.AddWithValue("@credito", amount); 
					dataAdapter.SelectCommand.Parameters.AddWithValue("@debito", 0);
					break;
			}
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

		}
	}
}
