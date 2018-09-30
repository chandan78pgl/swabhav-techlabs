using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleConnectionApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection simpleConnection = new SqlConnection(connectionInfo);

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student",simpleConnection);
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                simpleConnection.Open();
                Console.WriteLine("Connection is Open Now");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (simpleConnection.State==ConnectionState.Open)
                {
                    
                }
            }

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                string rollNo = dataReader[0].ToString();
                Console.WriteLine(rollNo);
            }

            simpleConnection.Close();
        }
    }
}
