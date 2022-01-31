using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != String.Empty)
            {
                ListBox1.Items.Add(TextBox1.Text);
                TextBox1.Text = String.Empty;
                 
                     ListBox1.Items.Add(Text1.Value);
            }
          
        }

      
    }
}