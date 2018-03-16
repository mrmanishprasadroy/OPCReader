using OPCReaderClient.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCReaderClient
{
    public partial class OPCClient : Form
    {
        private DatabaseConnection _DbCOnnection;
        private OPCServerConnection _OPCConnection;
        String _DataBaseConnection = "Connected to database";
        String _NoDataBaseConnection = "No connection to Database";

        String _OPCConnectionString = "Connected to OPC Service";
        String _NoOPCConnection = "No connection to OPC Service";
        bool DbCOnncetion = false;
        bool OPCCOnnection = false;
        
        public OPCClient()
        {
            InitializeComponent();
            ConnectSystem();
           
        }
        public void ConnectSystem()
        {
            _DbCOnnection = new DatabaseConnection();
            _OPCConnection = new OPCServerConnection();
            DbCOnncetion = _DbCOnnection.ConnectionState;

            OPCCOnnection = _OPCConnection.OPCConnect();

            if (DbCOnncetion && OPCCOnnection)
            {
                Connect.Text = _DataBaseConnection + "<---->" + _OPCConnectionString;
                Connect.BackColor = Color.Green;
            }
            else if (!DbCOnncetion && OPCCOnnection)
            {
                Connect.Text = _NoDataBaseConnection + "<---->" + _OPCConnectionString;
                Connect.BackColor = Color.Yellow;
            }
            else if (DbCOnncetion && !OPCCOnnection)
            {
                Connect.Text = _DataBaseConnection + "<---->" + _NoOPCConnection;
                Connect.BackColor = Color.Yellow;
            }
            else if (!DbCOnncetion && !OPCCOnnection)
            {
                Connect.Text = _NoDataBaseConnection + "<---->" + _NoOPCConnection;
                Connect.BackColor = Color.Red;
            }
        }
    }
}
