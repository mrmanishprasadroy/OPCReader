using OPCReaderClient.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCReaderClient.Connections
{
    public class DatabaseConnection
    {
        string _connectionString = string.Empty;
        private SqlConnection Database;
        private bool _ConnectionState;
        /// <summary>
        /// Initilizer
        /// </summary>
        public  DatabaseConnection()
        {
            _connectionString = AppConfig.Default.ConnectionString.ToString();

            if(!string.IsNullOrEmpty(_connectionString))
            {
                Database = new SqlConnection(_connectionString);
                try
                {
                    
                    Database.Open();
                    if(Database.State == System.Data.ConnectionState.Open)
                    {
                        _ConnectionState = true;
                    }
                    
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());

                }

            }
            else
            {
                MessageBox.Show("Error", "DataBase Parameter Not Define");
               // return _ConnectionState;
            }
        }
        /// <summary>
        /// Reconect Method
        /// </summary>
        /// <param name="Reconnect"></param>
        /// <returns></returns>
        public bool DatabaseConnect(bool Reconnect)
        {
            
            if(Reconnect)
            {
                Database = new SqlConnection(_connectionString);
                try
                {
                    Database.Open();
                    if (Database.State == System.Data.ConnectionState.Open)
                    {
                        _ConnectionState = true;
                    }
                    return _ConnectionState;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ErrorCode.ToString(), e.State.ToString());
                    _ConnectionState = false;
                    return _ConnectionState;
                }
                finally
                {
                    Database.Close();
                }

            }
            else
            {
                return _ConnectionState;
            }
        }
        /// <summary>
        /// Connection State
        /// </summary>
        public bool ConnectionState
        {
            get { return _ConnectionState; }

            set { _ConnectionState = value; }           
                                   
        }
        /// <summary>
        /// Insert Values 
        /// </summary>
        /// <returns></returns>
        public bool WriteValue(TEST_TABLE table)
        {
            bool RetValue = true;

            int Id = table.ID ?? 0;
            string FirstName = table.Name ?? string.Empty;
            string secondName = table.MidleName ?? string.Empty;
            string LastName = table.LastName ?? string.Empty;

            try
            {
                Database.Open();
                if(Database.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.CommandText = "Insert Into table";

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return RetValue;
        }
    }
}
