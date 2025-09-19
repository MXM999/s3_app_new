using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KN_MAX_3.SQL
{
    internal class Connection_SQL_MXM
    {
        public SqlConnection Conne;
        string ConnectionString = "Server = .\\MXM ; Database = TESTLVL_3 ; User Id = sa ; Password = 123 ; ";
        public void OpenConn()
        {
            Conne = new SqlConnection(ConnectionString);
            Conne.Open();
        }
        public void CloesConn()
        {
            Conne.Close();
        }
    }
}
