using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.lib
{
	public class SumAmounts
	{
		public static double Operation(DataTable tb, string columnName)
		{
			double result = 0;
			foreach (DataRow dr in tb.Rows) 
			{
				double values = Convert.ToDouble(dr[columnName]);
				result = result + values;
			}
			return result;
		}
	}
}
