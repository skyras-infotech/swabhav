using System;
using System.Data.SqlClient;
using System.Configuration;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlTransaction transaction = null;
            SqlCommand sqlCommand = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                conn.Open();
                FetchCustomer(sqlCommand, conn);
                FetchMerchant(sqlCommand, conn);
                Console.Write("Sumit, Enter money to pay reliance merchant ==> ");
                int amt = Convert.ToInt32(Console.ReadLine());
                transaction = conn.BeginTransaction();
                sqlCommand = new SqlCommand($"update CUST set BAL = BAL - {amt} where ID = 1",conn,transaction);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand($"update MERCHANT set BAL = BAL + {amt} where ID = 1",conn,transaction);
                sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Amount Paid successfully....\n");
                FetchCustomer(sqlCommand, conn);
                FetchMerchant(sqlCommand, conn);

            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private static void FetchCustomer(SqlCommand sqlCommand, SqlConnection conn)
        {
            string cmd = "select * from CUST";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("ID   Name   Balance");
            Console.WriteLine("=================");
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0].ToString() + "   " + dataReader[1].ToString() + "   " + dataReader[2]);
            }
            Console.WriteLine();
            dataReader.Close();
        }
        private static void FetchMerchant(SqlCommand sqlCommand, SqlConnection conn)
        {
            string cmd = "select * from MERCHANT";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("ID   Name   Balance");
            Console.WriteLine("=================");
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0].ToString() + "   " + dataReader[1].ToString() + "   " + dataReader[2]);
            }
            Console.WriteLine();
            dataReader.Close();
        }
    }
}
