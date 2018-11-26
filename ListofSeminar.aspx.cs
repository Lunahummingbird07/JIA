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
    public partial class ListofSeminar : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
            seminarinfo.Visible = false;
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            con.Open();
            string SeminarCode = TextBox1.Text;

            string qry = "select * FROM JIA.dbo.Seminar_List WHERE (Seminar_Code = '" + SeminarCode + "') ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            seminarinfo.DataSource = vbd;
            seminarinfo.DataBind();


            con.Close();
            seminarinfo.Visible = true;
        }

        protected void Button4_click(object sender, EventArgs e)
        {
            con.Open();

            string qry = "SELECT * FROM JIA.dbo.Seminar_List ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            seminarinfo.DataSource = vbd;
            seminarinfo.DataBind();


            con.Close();
            seminarinfo.Visible = true;

            foreach (DataListItem item in seminarinfo.Items)
            {
                Button Button2 = (Button)item.FindControl("Button2");
                Button2.Visible = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            string SeminarCode = b1.CommandArgument;
            con.Open();
            string qry1 = "select * FROM JIA.dbo.Seminar_List WHERE (Seminar_Code = '" + SeminarCode + "') ";
            SqlCommand cmd = new SqlCommand(qry1, con);
            SqlDataAdapter search = new SqlDataAdapter(cmd);

            DataTable a = new DataTable();
            search.Fill(a);
            editlist.DataSource = a;
            editlist.DataBind();
        }

        protected void Button3_click(object sender, EventArgs e)
        {
            try
            {
                Button b = sender as Button;
                string SeminarID = b.CommandArgument;


                foreach (DataListItem item in editlist.Items)
                {
                    con.Open();
                    TextBox TextBox4 = (TextBox)item.FindControl("TextBox4");
                    string SeminarCode = TextBox4.Text;
                    TextBox TextBox7 = (TextBox)item.FindControl("TextBox7");
                    string SeminarName = TextBox7.Text;
                    TextBox TextBox9 = (TextBox)item.FindControl("TextBox9");
                    string SeminarDate = TextBox9.Text;
                    TextBox TextBox10 = (TextBox)item.FindControl("TextBox10");
                    string SeminarLocation = TextBox10.Text;

                    string sqlinsertStatement1 = @"UPDATE JIA.dbo.Seminar_List SET Seminar_Code = '" + SeminarCode +
                                                "',Seminar_Name='" + SeminarName +
                                                "',Seminar_Date='" + SeminarDate +
                                                "',Seminar_Location='" + SeminarLocation +
                                                "'" + "WHERE Seminar_ID ='" + SeminarID + "'";

                    SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                    cmdTxt1.ExecuteNonQuery();
                    con.Close();
                }
                Response.Write("<script language='javascript'>window.alert('Saved');window.location='ListofSeminar.aspx';</script>");
            }
            catch 
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }

        protected void seminarinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void editlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}