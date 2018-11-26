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
    public partial class AddPledges : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);

        }

        protected void Button2_click(object sender, EventArgs e)
        {
            try
            {
                string fname = TextBox3.Text;
                string lname = TextBox4.Text;
                string pledge = TextBox1.Text;


                con.Open();
                string sqlinsertStatement1 = @"Insert Into JIA.dbo.Pledge (First_Name, Last_Name, pledge)
                                                    Values ('" + fname
                                                + "','" + lname + "','"
                                                + pledge + "')";


                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                cmdTxt1.ExecuteNonQuery();

                con.Close();
                Response.Write("<script language='javascript'>window.alert('Saved');window.location='AddPledges.aspx';</script>");
            }
            catch 
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }
    }
}