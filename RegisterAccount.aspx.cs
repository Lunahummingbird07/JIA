using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace JIA
{
    public partial class RegisterAccount : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = TextBox1.Text;
                string lname = TextBox3.Text;
                string username = TextBox4.Text;
                string password = TextBox2.Text;
                string typeofaccount = Request.Form["account"];

                con.Open();
                string sqlinsertStatement1 = @"Insert Into JIA.dbo.log_in (First_Name, Last_Name, [User_Name], [Password],Account)
                                                    Values ('" + fname
                                                + "','" + lname + "','"
                                                + username + "','"
                                                + password + "','"
                                                + typeofaccount + "')";


                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                cmdTxt1.ExecuteNonQuery();

                con.Close();
                Response.Write("<script language='javascript'>window.alert('Registered');window.location='login_page.aspx';</script>");
            }
            catch
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login_page.aspx");
        }
    }
}