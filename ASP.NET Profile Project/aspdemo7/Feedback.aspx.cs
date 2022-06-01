using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace aspdemo7
{
    public partial class Feedback : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sbmbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into feedback_tbl values(@lnam,@fnam,@email,@comment)";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@fnam",nametxt.Text);
            cmd.Parameters.AddWithValue("@lnam",Laname.Text);
            cmd.Parameters.AddWithValue("@email",emailtxt.Text);
            cmd.Parameters.AddWithValue("@comment",feedbtxt.Text);

            con.Open();

            int a=cmd.ExecuteNonQuery();

            if(a>0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('Thanks For Commenting');",true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "script", "<script> alert('Somthing Is Wrong')</script>");
            }
            con.Close();
        }
    }
}