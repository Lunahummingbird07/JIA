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
    public partial class CellGroup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
            cellgroupinfo.Visible = false;
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            con.Open();
            string CellGroupNumber = TextBox1.Text;

            string qry = "select * FROM JIA.dbo.Cell_Group_List WHERE (Cell_Group_Code = '" + CellGroupNumber + "') ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            cellgroupinfo.DataSource = vbd;
            cellgroupinfo.DataBind();

            
            con.Close();
            cellgroupinfo.Visible = true;
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            string CellGroupCode = b1.CommandArgument;
            con.Open();
            string qry1 = "select * FROM JIA.dbo.Cell_Group_List WHERE (Cell_Group_Code = '" + CellGroupCode + "')";
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
                string CellGroupNumber = b.CommandArgument;


                foreach (DataListItem item in editlist.Items)
                {
                    con.Open();
                    TextBox TextBox7 = (TextBox)item.FindControl("TextBox7");
                    string CellGroupName = TextBox7.Text;
                    TextBox TextBox9 = (TextBox)item.FindControl("TextBox9");
                    string CellLeader = TextBox9.Text;
                    TextBox TextBox10 = (TextBox)item.FindControl("TextBox10");
                    string CellFacilitator = TextBox10.Text;

                    string sqlinsertStatement1 = @"UPDATE JIA.dbo.Cell_Group_List SET Cell_Group_Name = '" + CellGroupName +
                                                "',Cell_Leader='" + CellLeader +
                                                "',Cell_Facilitator='" + CellFacilitator +
                                                "'" + "WHERE Cell_Group_No ='" + CellGroupNumber + "'";

                    SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                    cmdTxt1.ExecuteNonQuery();
                    con.Close();
                }
                Response.Write("<script language='javascript'>window.alert('Saved');window.location='CellGroup.aspx';</script>");

            }
            catch
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }

        protected void Button4_click(object sender, EventArgs e)
        {
            con.Open();

            string qry = "SELECT * FROM JIA.dbo.Cell_Group_List_Table ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);


            cellgroupinfo.DataSource = vbd;
            cellgroupinfo.DataBind();


            con.Close();
            cellgroupinfo.Visible = true;
            
            foreach (DataListItem item in cellgroupinfo.Items)
            {
                Button Button2 = (Button)item.FindControl("Button2");
                Button2.Visible = false;
            }
        }
    }
}