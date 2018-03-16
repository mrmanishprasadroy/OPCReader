using OPCReaderClient.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCReaderClient.DataModel
{
    public class DataClass
    {
        private TEST_TABLE Table;

        public DataClass()
        {
            Table = new TEST_TABLE();
        }

        public TEST_TABLE getTable()
        {
            return Table;
        }
    }
}
