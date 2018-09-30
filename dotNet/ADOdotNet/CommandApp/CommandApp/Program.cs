using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection simpleConnection = new SqlConnection(connectionInfo);

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student", simpleConnection);
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                simpleConnection.Open();
                Console.WriteLine("Connection is Open Now");

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string rollNo = dataReader[0].ToString();
                    string firstName = dataReader[1].ToString();
                    string lastName = dataReader[2].ToString();
                    string CGPA = dataReader[3].ToString();
                    
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0} | {1} | {2} | {3}",rollNo,firstName,lastName,CGPA);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (simpleConnection.State == ConnectionState.Open)
                {
                    simpleConnection.Close();
                }
            }
        }
    }
}
