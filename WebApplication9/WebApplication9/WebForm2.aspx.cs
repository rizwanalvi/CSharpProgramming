using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection _conn = new SqlConnection();
        SqlCommand _cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadData();
            }
            
          
            

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
        }

        private void LoadData()
        {

            _conn.ConnectionString = @"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _conn.Open();
            _cmd.Connection = _conn;
            _cmd.CommandText = "SELECT * FROM Mobiles";
            SqlDataReader _dReader = _cmd.ExecuteReader();
            GridView1.DataSource = _dReader;
            GridView1.DataBind();
            _conn.Close();
           

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow _dRow = GridView1.Rows[e.RowIndex];
             Label _lblid =  _dRow.FindControl("Labelx") as Label;
            TextBox _txtMobile = (TextBox) _dRow.FindControl("TextBox1");
            _conn.ConnectionString = @"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _conn.Open();
            _cmd.Connection = _conn;
            _cmd.CommandText = "UPDATE Mobiles SET MNAME = @MNAME WHERE ID =@ID";
            _cmd.Parameters.AddWithValue("@ID",_lblid.Text);
            _cmd.Parameters.AddWithValue("@MNAME", _txtMobile.Text);
            _cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
             _conn.Close();
            LoadData();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow _dRow = GridView1.Rows[e.RowIndex];
            Label _lblid = _dRow.FindControl("Labelx") as Label;
             _conn.ConnectionString = @"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _conn.Open();
            _cmd.Connection = _conn;
            _cmd.CommandText = "DELETE FROM MOBILES WHERE ID =@ID";
            _cmd.Parameters.AddWithValue("@ID", _lblid.Text);
            _cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            _conn.Close();
            LoadData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _conn.ConnectionString = @"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _conn.Open();
            _cmd.Connection = _conn;
            _cmd.CommandText = "INSERT INTO MOBILES(MNAME) VALUES(@MNAME)";
            _cmd.Parameters.AddWithValue("@MNAME", TextBox2.Text);
            _cmd.ExecuteNonQuery();
            _conn.Close();
            LoadData();
        }
    }
}