using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreApp
{
    public partial class Form1 : Form
    {
        MobileEntities _mbdb = new MobileEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _user = _mbdb.USERS.Where(x => x.USERNAME == textBox1.Text && x.PASSWORD == textBox2.Text).Count();
            if (_user >0)
            {
                new frmDashboard().Show();
                this.Visible = false;
            }
            else {
                MessageBox.Show("Invalid Username/password");
            }
        }
    }
}
