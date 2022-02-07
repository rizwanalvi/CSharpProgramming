using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppCrud
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
           
        }
        private void LoadData() {

            SqlConnection _SqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=Shops;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_SqlConn.State != System.Data.ConnectionState.Open)
            {
                _SqlConn.Open();
            }
            SqlCommand _Cmd = new SqlCommand("SELECT * FROM PRODUCT", _SqlConn);
            SqlDataReader _dReader = _Cmd.ExecuteReader();
            GridView1.DataSource = _dReader;
            GridView1.DataBind();

            _SqlConn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection _SqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=Shops;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_SqlConn.State != System.Data.ConnectionState.Open) {
                _SqlConn.Open();
            }
                     
            SqlCommand _Cmd = new SqlCommand("INSERT INTO PRODUCT VALUES(@PNAME,@PDES,@PPRICE)",_SqlConn);
            _Cmd.Parameters.AddWithValue("@PNAME",TextBox1.Text);
            _Cmd.Parameters.AddWithValue("@PDES",TextBox3.Text);
            _Cmd.Parameters.AddWithValue("@PPRICE", TextBox2.Text);
            _Cmd.ExecuteNonQuery();
            _SqlConn.Close();

            LoadData();
        }
    }
}