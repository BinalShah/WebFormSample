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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con;
            //Here we declare the parameter which we have to use in our application  
            SqlCommand cmd = new SqlCommand();
           
            con = new SqlConnection("server=(local); database= StudentData;integrated security= true");
            string sql = "Select * from Student";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
                      
            con.Close();
        }
    }
    }
