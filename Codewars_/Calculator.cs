using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_
{
    public class Evaluator
    {
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            Console.WriteLine(row[expression].ToString());
            //Console.WriteLine(table.Rows[expression].ToString());
            return double.Parse((string)row["expression"]);
        }
    }
}
