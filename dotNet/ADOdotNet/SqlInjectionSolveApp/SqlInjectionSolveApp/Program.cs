using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionSolveApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionInfo);

            try
            {
                connection.Open();
                Console.WriteLine("Connection is Open Now");
                Console.Write("Enter Roll No: ");

                string rollNoValue = Console.ReadLine();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student WHERE rollNo=@param1", connection);
                sqlCommand.Parameters.Add("@param1",SqlDbType.VarChar,20);
                sqlCommand.Parameters["@param1"].Value=rollNoValue;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    string rollNo = dataReader[0].ToString();
                    string firstName = dataReader[1].ToString();
                    string lastName = dataReader[2].ToString();
                    string CGPA = dataReader[3].ToString();

                    Console.WriteLine("{0} | {1} | {2} | {3}", rollNo, firstName, lastName, CGPA);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
