using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCReaderClient.Connections
{
    public class OPCServerConnection
    {
        public OPCServerConnection()
        {
            // create a new client to connect to  a server 
        }
        public bool OPCConnect()
        {
            string Path = AppConfig.Default.DATABASE.ToString();
            bool Reconnect = AppConfig.Default.Reconnect;

            
            return true;
        }
    }
}
