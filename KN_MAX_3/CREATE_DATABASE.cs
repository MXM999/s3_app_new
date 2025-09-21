using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN_MAX_3
{
    internal class CREATE_DATABASE
    {
        public static SqlConnection conn;
        static SqlCommand cmd;
        public static string new_Db = "";

        public static int CreateNewDataBase()
        {
            try
            {
                string m_SQL_DB = @"Server= .\mxm ;Database= master ;User Id= sa ;Password= 123;";
                conn = new SqlConnection(m_SQL_DB);
                conn.Open();
                if (CheckDBIsExists())
                {
                    return 0;
                }
                string New_Db = @"CREATE DATABASE TESTLVL_3";
                cmd = new SqlCommand(New_Db, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                new_Db = @"Server= .\mxm ;Database= TESTLVL_3 ;User Id= sa ;Password= 123;";
                conn = new SqlConnection(new_Db);
                CreateTable();
                return 2;
            }
            catch
            {
                return 1;
            }

        }
        private static bool CheckDBIsExists()
        {
            string CH = @"IF NOT EXISTS(SELECT NAME FROM SYS.DATABASES WHERE NAME = 'TESTLVL_3')
                            BEGIN 
                             SELECT 0
                            END 
                          ELSE 
                            BEGIN 
                             SELECT 1
                            END";
            cmd = new SqlCommand(CH, conn);
            int t = Convert.ToInt32(cmd.ExecuteScalar());
            if (t == 1)
            {
                return true;
            }
            return false;
        }

        private static void CreateTable()
        {
            string Cr_tb =
                           @"CREATE TABLE GENDER 
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY, 
                           KIND VARCHAR(255)
                           )
                           CREATE TABLE CLASS
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY, 
                           NAME_CLASS VARCHAR(255),
                           MAX_STU INT
                           )
                           
                           CREATE TABLE STUDENT 
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY,
                           NAME_STU VARCHAR(255),
                           PHONE VARCHAR(255),
                           GUID_GEN UNIQUEIDENTIFIER FOREIGN KEY REFERENCES GENDER (ID)
                           )
                           
                           CREATE TABLE TECH 
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY,
                           NAME_TECH VARCHAR(255),
                           PHONE VARCHAR(255),
                           GUID_GEN UNIQUEIDENTIFIER FOREIGN KEY REFERENCES GENDER (ID)
                           )
                           
                           CREATE TABLE STU_CLASS
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY,
                           GUID_CLASS UNIQUEIDENTIFIER FOREIGN KEY REFERENCES CLASS (ID),
                           GUID_STU UNIQUEIDENTIFIER FOREIGN KEY REFERENCES STUDENT (ID)
                           )
                           
                           CREATE TABLE TECH_CLASS
                           (
                           ID UNIQUEIDENTIFIER PRIMARY KEY,
                           GUID_CLASS UNIQUEIDENTIFIER FOREIGN KEY REFERENCES CLASS (ID),
                           GUID_TECH UNIQUEIDENTIFIER FOREIGN KEY REFERENCES TECH (ID)
                           )
                           ";
            conn.Open();
            cmd = new SqlCommand(Cr_tb, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
