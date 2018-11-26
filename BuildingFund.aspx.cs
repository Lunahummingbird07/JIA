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
    public partial class BuildingFund : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);


            con.Open();
            string qry = "select * FROM JIA.dbo.Building_Fund ";


            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);

            buildingfundinfo.DataSource = vbd;
            buildingfundinfo.DataBind();




            con.Close();

        }

        protected void Button3_click(object sender, EventArgs e)
        {
            try
            {
                string datecollected = TextBox7.Text;
                string amountcollected = TextBox4.Text;


                con.Open();
                string sqlinsertStatement1 = @"Insert Into JIA.dbo.Building_Fund (Date_Collected, Amount_Collected)
                                                    Values ('" + datecollected + "','" + amountcollected + "')";


                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                cmdTxt1.ExecuteNonQuery();

                con.Close();
                Response.Write("<script language='javascript'>window.alert('Fund Added');window.location='AddPledges.aspx';</script>");
            }
            catch
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox7.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            string entrynum = b1.CommandArgument;
            con.Open();
            string sqlinsertStatement1 = @"DELETE FROM JIA.dbo.Building_Fund WHERE ( Entry_No = '" + entrynum + "') ";


            SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
            cmdTxt1.ExecuteNonQuery();

            con.Close();
            Response.Write("<script language='javascript'>window.alert('Fund Deleted');window.location='AddPledges.aspx';</script>");

        }
    }
}