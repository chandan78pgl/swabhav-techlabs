using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EmpandDeptForm
{
    public partial class EmpAndDeptForm : Form
    {
        private string _connectionInfo;
        private SqlConnection _connection;
        private SqlCommand _EmpCommand;
        private SqlCommand _DeptCommand;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;

        public EmpAndDeptForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void btnEmpShow_Click(object sender, EventArgs e)
        {
            try
            {
                _dataAdapter = new SqlDataAdapter(_EmpCommand);
                _dataAdapter.Fill(_dataSet,"EMP");
                empDataGridView.DataSource = _dataSet.Tables["EMP"];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDeptShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(_DeptCommand);
                dataAdapter.Fill(_dataSet,"DEPT");
                deptDataGridView.DataSource = _dataSet.Tables["DEPT"];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void InitializeDatabaseConnection()
        {
            _connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            _connection = new SqlConnection(_connectionInfo);
            _EmpCommand = new SqlCommand("SELECT * FROM EMP", _connection);
            _DeptCommand = new SqlCommand("SELECT * FROM DEPT", _connection);
            _dataSet = new DataSet();
        }
    }
}
