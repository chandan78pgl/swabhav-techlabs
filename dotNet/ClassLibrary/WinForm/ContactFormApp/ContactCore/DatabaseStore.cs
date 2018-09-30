using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactCore
{
    public class DatabaseStore
    {
        private static string _connectionInfo;
        private static SqlConnection _connection;
        private static SqlCommand _contactSelectCommand;
        private static SqlCommand _contactInsertCommand;
        private static SqlDataAdapter _dataAdapter;
        private static DataSet _dataSet;

        public static void SaveDataToDatabase(Contact contact)
        {
            _contactInsertCommand.Parameters["@param1"].Value = contact.Name;
            _contactInsertCommand.Parameters["@param2"].Value = contact.Number;

            _contactInsertCommand.CommandType = CommandType.Text;

            try
            {
                _connection.Open();
                _contactInsertCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        public static List<Contact> GetDataFromDatabase()
        {
            InitializeDatabaseConnection();
            List<Contact> contacts = new List<Contact>();
            string name;
            string number;

            _dataAdapter = new SqlDataAdapter(_contactSelectCommand);
            _dataAdapter.Fill(_dataSet, "Contacts");

            foreach (DataRow contactRow in _dataSet.Tables["Contacts"].Rows)
            {
                name = contactRow["name"].ToString();
                number = contactRow["number"].ToString();
                contacts.Add(new Contact(name, number));
            }

            return contacts;
        }

        private static void InitializeDatabaseConnection()
        {
            _connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            _connection = new SqlConnection(_connectionInfo);
            _contactSelectCommand = new SqlCommand("SELECT * FROM CONTACTS", _connection);
            _contactInsertCommand = new SqlCommand("INSERT INTO CONTACTS(name,number) VALUES(@param1,@param2)",_connection);
            _contactInsertCommand.Parameters.Add("@param1", SqlDbType.VarChar, 20);
            _contactInsertCommand.Parameters.Add("@param2", SqlDbType.VarChar, 20);

            _dataSet = new DataSet();
        }
    }
}
