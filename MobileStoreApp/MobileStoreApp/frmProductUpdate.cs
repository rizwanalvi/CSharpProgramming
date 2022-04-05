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
    public partial class frmProductUpdate : Form
    {
        MobileEntities _mb = new MobileEntities();
        public frmProductUpdate(int id,String Name)
        {
            InitializeComponent();
            this.textBox1.Text = Name;
        }
        public frmProductUpdate(int id, String Name,string price,string quantity,string desc,string cat)
        {
            InitializeComponent();
            ImageConverter _im = new ImageConverter();
            this.textBox1.Text = Name;
            this.textBox2.Text = price.ToString();
            this.textBox3.Text = quantity.ToString();
            this.textBox4.Text = desc;
           this.label6.Text = id.ToString();
            this.pictureBox1.Image = img;
            this.comboBox1.Items.Add(cat);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageConverter _img = new ImageConverter();
        
            Mobile _mob = _mb.Mobiles.Where(x => x.ID == 1).Single();
            _mob.PRONAME = this.textBox1.Text;
            _mob.PRICE = double.Parse(textBox2.Text);
            _mob.QUANTITY = int.Parse(textBox3.Text);
            _mob.DESP = textBox4.Text;
            _mob.IMG = (byte[]) _img.ConvertTo(pictureBox1.Image, typeof(byte[]));
            _mb.SaveChanges();

        }
    }
}
