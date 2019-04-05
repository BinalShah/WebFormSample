using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con;
            //Here we declare the parameter which we have to use in our application  
            SqlCommand cmd = new SqlCommand();
            SqlParameter sp1 = new SqlParameter();
            SqlParameter sp2 = new SqlParameter();
            SqlParameter sp3 = new SqlParameter();
            SqlParameter sp4 = new SqlParameter();
            
                con = new SqlConnection("server=(local); database= StudentData;integrated security= true");
            cmd = new SqlCommand("submitrecord", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = TextBox4.Text;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox1.Text;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox2.Text;
                cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = TextBox3.Text;
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
    }
}