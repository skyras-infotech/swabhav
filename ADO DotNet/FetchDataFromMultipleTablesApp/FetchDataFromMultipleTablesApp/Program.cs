using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FetchDataFromMultipleTablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand("spGetTablesData", conn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                DataTable dtEMP = dataSet.Tables[0];
                DataTable dtDEPT = dataSet.Tables[1];
                Console.WriteLine("\t===== Employee Table ======\n");
                // Print EMP data
                foreach (DataRow dataRow in dtEMP.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.Write(item+"    ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
                Console.WriteLine("\t===== Department Table ======\n");
                // Print DEPT data
                foreach (DataRow dataRow in dtDEPT.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.Write(item + "    ");
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
