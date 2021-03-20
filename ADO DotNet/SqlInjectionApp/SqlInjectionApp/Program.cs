using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace SqlInjectionApp
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
        private static void FetchData(SqlCommand sqlCommand, SqlConnection conn)
        {
            Console.Write("Enter EMPNO ==> ");
            string str = Console.ReadLine();
            string cmd = $"select * from EMP where EMPNO = @empno";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlParameter empnoParam = new SqlParameter("@empno", SqlDbType.Int, 0);
            empnoParam.Value = str;
            sqlCommand.Parameters.Add(empnoParam);
            sqlCommand.Prepare();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0].ToString() + "   " + dataReader[1].ToString() + "   " + dataReader[2]);
            }
            Console.WriteLine();
            dataReader.Close();
        }
    }
}
