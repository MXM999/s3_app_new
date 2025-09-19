using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KN_MAX_3.SQL;

namespace KN_MAX_3
{
    public partial class MainUI : Form
    {
        Connection_SQL_MXM Conne_test;
        AddGender m_Gen;
        add_Class m_CLass;
        public MainUI()
        {
            InitializeComponent();
        }
       

        private void ADD_ST_bt_Click(object sender, EventArgs e)
        {
           
        }

        private void ADD_GR_BT_Click(object sender, EventArgs e)
        {
           m_Gen = new AddGender();
           m_Gen.Show();
        }

        private void ADD_CL_BT_Click(object sender, EventArgs e)
        {
            m_CLass = new add_Class();
            m_CLass.Show();
        }

        private void ADD_TECH_BT_Click(object sender, EventArgs e)
        {

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
    }
}
