using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SmartEntities _Smartdb = new SmartEntities();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)

        {
            ImageConverter _convert = new ImageConverter();
            byte[] _bmp = (byte[]) _convert.ConvertTo(pictureBox1.Image,typeof(byte[]));
            _Smartdb.Products.Add(new Product {
                PRONAME = textBox1.Text,
                PRICE = double.Parse(textBox2.Text),
                QUANTITY = int.Parse(textBox3.Text),
                INSTOCT = 1,
                POSTER =_bmp
                });
            _Smartdb.SaveChanges();
            MessageBox.Show("Data has been inserted.");
            LoadGrid();
        }
        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            var _data = _Smartdb.Products;
            foreach (var item in _data)
            {
                dataGridView1.Rows.Add(new object[] { item.ID, item.PRONAME, item.PRICE, item.QUANTITY, item.INSTOCT, item.POSTER });
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
