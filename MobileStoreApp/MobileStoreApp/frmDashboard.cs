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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProduct().Show();
        }
    }
}
