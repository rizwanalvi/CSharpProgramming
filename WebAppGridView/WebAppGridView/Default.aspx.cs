using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppGridView
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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           GridViewRow _dRow = (GridViewRow) GridView1.Rows[e.RowIndex];
            //TextBox _txtName = (TextBox) _dRow.FindControl("TextBox1");
            TextBox _txtName =_dRow.FindControl("TextBox1") as TextBox;
            Label _lblId = _dRow.FindControl("LabelX") as Label;
            try
            {
                SqlConnection _SqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                _SqlConn.Open();
                SqlCommand _cmd = new SqlCommand("UPDATE Mobiles SET MNAME=@MNAME WHERE ID =@ID", _SqlConn);
                _cmd.Parameters.AddWithValue("@ID", _lblId.Text);
                _cmd.Parameters.AddWithValue("@MNAME", _txtName.Text);
                _cmd.ExecuteNonQuery();
                _SqlConn.Close();
            }
            catch (Exception ex)
            {

            }

            GridView1.EditIndex = -1;
            LoadData();
        }
        private void UpdateData() {


        
}
        private void LoadData()
        {


            try
            {
                SqlConnection _SqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=MobileDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                _SqlConn.Open();
                SqlCommand _cmd = new SqlCommand("SELECT * FROM Mobiles", _SqlConn);
                SqlDataReader _dReader = _cmd.ExecuteReader();
                GridView1.DataSource = _dReader;
                GridView1.DataBind();
                _SqlConn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}