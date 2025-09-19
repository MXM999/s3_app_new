using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KN_MAX_3.SQL
{
    internal class Insert
    {
        Connection_SQL_MXM Conne_Plus;
        SqlCommand Command_plus;

        public Insert()
        {
            Conne_Plus = new Connection_SQL_MXM();
        }
        public bool InsertGender(string Name_Of_Type)
        {
            try
            {
                Conne_Plus.OpenConn();
                string Qur_Insert_Gr = "INSERT INTO GENDER VALUES ('" + Guid.NewGuid() + "' , '" + Name_Of_Type + "')";
                Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool InsertClass(string Name_Class , int max_size)
        {
            try
            {
                Conne_Plus.OpenConn();
                string Qur_Insert_Gr = "INSERT INTO CLASS VALUES ('" + Guid.NewGuid() + "','"+ Name_Class + "' , "+ max_size + ")";
                Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
