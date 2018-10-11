using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    public class Transaction
    {
        private string _connectionInfo;
        private SqlConnection _connection;

        private SqlCommand _customerUpdateCommand;
        private SqlCommand _merchantUpdateCommand;

        private SqlTransaction transaction = null;

        public Transaction()
        {
            InitializeDatabaseConnection();
        }
        
        public void DoTransaction(Customer customer, Merchant merchant,int amount)
        {
            
            customer.CustomerBalance = customer.CustomerBalance - amount;
            merchant.MerchantBalance = merchant.MerchantBalance + amount;

            _connection.Open();
            transaction = _connection.BeginTransaction();

            _customerUpdateCommand.Transaction = transaction;
            _merchantUpdateCommand.Transaction = transaction;

            _customerUpdateCommand.Parameters["@param1"].Value = customer.CustomerBalance;
            _merchantUpdateCommand.Parameters["@param2"].Value = merchant.MerchantBalance;

            try
            {
                _customerUpdateCommand.ExecuteNonQuery();
                _merchantUpdateCommand.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
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

        private void InitializeDatabaseConnection()
        {
            _connectionInfo = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            _connection = new SqlConnection(_connectionInfo);

            _customerUpdateCommand = new SqlCommand("UPDATE CUSTOMER SET customer_balance=@param1 WHERE customer_id=1", _connection);
            _merchantUpdateCommand = new SqlCommand("UPDATE MERCHANT SET merchant_balance=@param2 WHERE merchant_id=1", _connection);
 
            _customerUpdateCommand.Parameters.Add("@param1", SqlDbType.VarChar, 20);
            _merchantUpdateCommand.Parameters.Add("@param2", SqlDbType.VarChar, 20);
        }
    }
}
