using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KN_MAX_3.SQL
{
    internal class GetData
    {
        Connection_SQL_MXM m_Conne_Plus;
        SqlCommand m_Command_plus;
        SqlDataReader m_Reader;

        public GetData()
        {
            m_Conne_Plus = new Connection_SQL_MXM();
        }
        public void GetGender(List<model> GR_list)
        {
            m_Conne_Plus.OpenConn();
            string Qury = "SELECT * FROM GENDER";
            m_Command_plus = new SqlCommand(Qury, m_Conne_Plus.Conne);
            m_Reader = m_Command_plus.ExecuteReader();
            while (m_Reader.Read())
            {
                GR_list.Add(new model { ID = Guid.Parse(m_Reader.GetSqlValue(0).ToString()), type = m_Reader.GetSqlValue(1).ToString() });
            }
            m_Conne_Plus.CloesConn();
        }
        public void GetClass(List<model> Cl_list)
        {
            m_Conne_Plus.OpenConn();
            string Qury = "SELECT * FROM CLASS";
            m_Command_plus = new SqlCommand(Qury, m_Conne_Plus.Conne);
            m_Reader = m_Command_plus.ExecuteReader();
            while (m_Reader.Read())
            {
                Cl_list.Add(new model { ID = Guid.Parse(m_Reader.GetSqlValue(0).ToString()), Name = m_Reader.GetSqlValue(1).ToString() });
            }
            m_Conne_Plus.CloesConn();
        }
    }
}
