using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Models;
namespace WebApplication5
{
    public partial class frmStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student _std = new Student();
            GridView1.DataSource = _std.GetAllStudent();
            GridView1.DataBind();
        }
    }
}