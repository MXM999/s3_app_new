using KN_MAX_3.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KN_MAX_3
{
    public partial class MainUI : Form
    {
        Connection_SQL_MXM Conne_test;
        AddGender m_Gen;
        AddStudnt m_studnet_add;
        add_Class m_CLass;
        ADD__Tech m_tech;
        public MainUI()
        {
            InitializeComponent();
        }
       

        private void ADD_ST_bt_Click(object sender, EventArgs e)
        {
            m_studnet_add = new AddStudnt();
            m_studnet_add.Show();
            this.Hide();
        }

        private void ADD_GR_BT_Click(object sender, EventArgs e)
        {
           m_Gen = new AddGender();
           m_Gen.Show();
           this.Hide();
        }

        private void ADD_CL_BT_Click(object sender, EventArgs e)
        {
            m_CLass = new add_Class();
            m_CLass.Show();
            this.Hide();
        }

        private void ADD_TECH_BT_Click(object sender, EventArgs e)
        {
            m_tech = new ADD__Tech();
            m_tech.Show();
            this.Hide();
        }
        private void EXIT_BT_Click(object sender, EventArgs e)
        {
            DialogResult end = MessageBox.Show("You Want Exit", "Make Suer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (end == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Test_bt_Click(object sender, EventArgs e)
        {
            Conne_test = new Connection_SQL_MXM();
            Conne_test.OpenConn();
            MessageBox.Show(Conne_test.Conne.State.ToString());
            Conne_test.CloesConn();
        }

        private void Create_db_Click(object sender, EventArgs e)
        {

             DialogResult choes =   MessageBox.Show("Create New Database", "Create DB", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == choes)
            {
                DialogResult sure = MessageBox.Show("سوف يتم حذف جيمع المعلومات", "delete all Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sure == DialogResult.Yes)
                {
                    int create_stat = CREATE_DATABASE.CreateNewDataBase();
                    if (create_stat == 0)
                    {
                        MessageBox.Show("القاعدة موجودة مسبقاً");
                    }
                    else if (create_stat == 1)
                    {
                        MessageBox.Show("خطأ في أسم السيرفر قم بتعديله من الكود ");
                    }
                    else if (create_stat == 2)
                    {
                        MessageBox.Show("تم أنشاء القاعدة بنجاح");
                    }

                }
                else
                {
                    MessageBox.Show(" بل الناقص على جبنة");

                }
            } 
            else
            {
                MessageBox.Show("بل الناقص");
            }
        }
    }
}
