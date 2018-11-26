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
    public partial class AddSeminar : System.Web.UI.Page
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
                string SeminarCode = TextBox3.Text;
                string SeminarName = TextBox4.Text;
                string SeminarDate = TextBox5.Text;
                string SeminarLocation = TextBox6.Text;


                con.Open();
                string sqlinsertStatement1 = @"Insert Into JIA.dbo.Seminar_List (Seminar_Code, Seminar_Name, Seminar_Date, Seminar_Location)
                                                Values ('" + SeminarCode
                                                + "','" + SeminarName + "','"
                                                + SeminarDate + "','"
                                                + SeminarLocation + "')";


                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                cmdTxt1.ExecuteNonQuery();

                con.Close();
                Response.Write("<script language='javascript'>window.alert('Saved');window.location='AddCellGroup.aspx';</script>");
            }
            catch
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }
    }
}