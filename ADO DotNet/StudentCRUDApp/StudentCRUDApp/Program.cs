using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand sqlCommand = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                conn.Open();
                FetchData(sqlCommand, conn);

                // insert data
                string insertData = "insert into students values('Sumit',50);";
                Console.WriteLine(insertData+"\n");
                sqlCommand = new SqlCommand(insertData, conn);
                sqlCommand.ExecuteNonQuery();
                FetchData(sqlCommand, conn);

                // update data
                string updateData = "update students set name='Sumit Gupta' where id=" + 7;
                Console.WriteLine(updateData+"\n");
                sqlCommand = new SqlCommand(updateData, conn);
                sqlCommand.ExecuteNonQuery();
                FetchData(sqlCommand, conn);

                // delete data
                string deleteData = "delete from students where id = " + 2;
                Console.WriteLine(deleteData+"\n");
                sqlCommand = new SqlCommand(deleteData, conn);
                sqlCommand.ExecuteNonQuery();
                FetchData(sqlCommand, conn);

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
        private static void FetchData(SqlCommand sqlCommand,SqlConnection conn) {
            string cmd = "select * from students";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("No   Name   Age");
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
