using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppImageUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO POSTER VALUES(@IMG)",_sqlConn);
            _cmd.Parameters.AddWithValue("@IMG", FileUpload1.FileBytes);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();
            LoadData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Image1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(FileUpload1.FileBytes);
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM POSTER", _sqlConn);
           SqlDataReader _dReader =  _cmd.ExecuteReader();
            while (_dReader.Read())
            {
                Image1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[]) _dReader["IMGPATH"]);
            }
        }

        private void LoadData() {
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM POSTER", _sqlConn);
            SqlDataReader _dReader = _cmd.ExecuteReader();
            GridView1.DataSource = _dReader;
            GridView1.DataBind();

        }
    }
}