using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Connection Sucessfull...!\nConnectionString is : " + conn.ConnectionString);
                Console.WriteLine("Connection Timeout :" + conn.ConnectionTimeout);
                Console.WriteLine("Connected Database :" + conn.Database);
                Console.WriteLine("Connected DataSource :" + conn.DataSource);
                Console.WriteLine("Credential :" + conn.Credential);
                Console.WriteLine("Schema information of Datasource : " + conn.GetSchema());
                Console.WriteLine("the state of the SqlConnection :" + conn.State);
                Console.WriteLine("the version of the instance of SQL Server : " + conn.ServerVersion);
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
