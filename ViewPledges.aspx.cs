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
    public partial class ViewPledges : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
           pledgeinfo.Visible = false;
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            con.Open();
            string pledgeid = TextBox1.Text;

            string qry = "select * FROM JIA.dbo.Pledge WHERE (Pledge_ID = '" + pledgeid + "') ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            pledgeinfo.DataSource = vbd;
            pledgeinfo.DataBind();


            con.Close();
            pledgeinfo.Visible = true;
        }

        protected void Button4_click(object sender, EventArgs e)
        {
            con.Open();

            string qry = "SELECT * FROM JIA.dbo.Pledge ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            pledgeinfo.DataSource = vbd;
            pledgeinfo.DataBind();


            con.Close();
            pledgeinfo.Visible = true;

            foreach (DataListItem item in pledgeinfo.Items)
            {
                Button Button2 = (Button)item.FindControl("Button2");
                Button2.Visible = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            string pledgeid = b1.CommandArgument;
            con.Open();
            string qry1 = "select * FROM JIA.dbo.Pledge WHERE (Pledge_ID = '" + pledgeid + "') ";
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
                string PledgeID = b.CommandArgument;


                foreach (DataListItem item in editlist.Items)
                {
                    con.Open();
                    TextBox TextBox4 = (TextBox)item.FindControl("TextBox4");
                    string fname = TextBox4.Text;
                    TextBox TextBox7 = (TextBox)item.FindControl("TextBox7");
                    string lname = TextBox7.Text;
                    TextBox TextBox9 = (TextBox)item.FindControl("TextBox9");
                    string pledge = TextBox9.Text;

                    string sqlinsertStatement1 = @"UPDATE JIA.dbo.Pledge SET First_Name = '" + fname +
                                                "',Last_Name='" + lname +
                                                "',pledge='" + pledge +
                                                "'" + "WHERE Pledge_ID ='" + PledgeID + "'";

                    SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                    cmdTxt1.ExecuteNonQuery();
                    con.Close();
                }
                Response.Write("<script language='javascript'>window.alert('Saved');window.location='ViewPledges.aspx';</script>");
            }
            catch
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }
    }
}