using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetApp
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection simpleConnection = new SqlConnection(connectionInfo);

            

            try
            {

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student", simpleConnection);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet,"Student");
                dataGridView.DataSource = dataSet.Tables["Student"];
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);  
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
