using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    public class LoginRepository
    {
        private string _userName;
        private string _password;
        private string _connectionInfo;
        private SqlConnection _connection;
        private SqlCommand _loginSelectCommand;
        private SqlCommand _contactInsertCommand;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;

        public LoginRepository()
        {
            InitializeDatabaseConnection();
            GetLoginDetailsFromDataBase();
        }
        public String UserName
        {
            get
            {
                return _userName;
            }
        }

        public String Password
        {
            get
            {
                return _password;
            }
        }

        private void GetLoginDetailsFromDataBase()
        {
            _dataAdapter = new SqlDataAdapter(_loginSelectCommand);
            _dataAdapter.Fill(_dataSet, "LoginUser");

            foreach (DataRow contactRow in _dataSet.Tables["LoginUser"].Rows)
            {
                _userName = contactRow["userID"].ToString();
                _password = contactRow["password"].ToString();
            }
        }

        private void InitializeDatabaseConnection()
        {
            _connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            _connection = new SqlConnection(_connectionInfo);
            _loginSelectCommand = new SqlCommand("SELECT * FROM LOGINUSERS", _connection);
            _dataSet = new DataSet();
        }
    }
}
