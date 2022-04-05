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
    public partial class frmProduct : Form
    {
        MobileEntities _mb = new MobileEntities();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled =false;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            foreach (var item in _mb.Mobiles)
            {
                dataGridView1.Rows.Add(new object[] { item.ID, item.PRONAME, item.PRICE, item.QUANTITY, item.DESP,item.CATEGORY,item.IMG });
            }
           
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex.ToString()
           
            int _id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string _name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string _price = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string _quant = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           string _desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string _cat = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           // Image _img =  (Image) dataGridView1.Rows[e.RowIndex].Cells[6].Value;
           
            new frmProductUpdate(_id,_name,_price,_quant,_desc,_cat).Show();
        }
    }
}
