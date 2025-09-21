using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN_MAX_3.SQL
{
    internal class CheackData
    {
        Connection_SQL_MXM m_Conne_Plus;
        SqlCommand m_Command;
        public model m_model;
        SqlDataReader m_Reader;

        public CheackData()
        {
            m_Conne_Plus = new Connection_SQL_MXM();
        }
        public bool IsNameExist(string Name_stu)
        {
            m_Conne_Plus.OpenConn();
            string Qury = "SELECT count(*)  FROM STUDENT WHERE NAME_STU = '" + Name_stu + "' ";
            m_Command = new SqlCommand(Qury, m_Conne_Plus.Conne);
            int x = (int)m_Command.ExecuteScalar();
            m_Conne_Plus.CloesConn();
            if (x == 1)
            {
                GetGuid(Name_stu);
                return true;

            }
            return false;
        }
        private void GetGuid(string Name)
        {
            m_model = new model();
            m_Conne_Plus.OpenConn();
            string Qury = "SELECT  * FROM STUDENT WHERE NAME_STU = '" + Name + "' ";
            m_Command = new SqlCommand(Qury, m_Conne_Plus.Conne);
            m_Reader = m_Command.ExecuteReader();
            if (m_Reader.Read())
            {
                m_model.ID = Guid.Parse(m_Reader.GetSqlValue(0).ToString());
            }
            m_Conne_Plus.CloesConn();

        }
    }
}
