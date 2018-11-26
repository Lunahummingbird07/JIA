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
    public partial class MemberMainPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
            personinfo.Visible = true;
            editlist.Visible = true;
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            con.Open();
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string qry = "select * FROM JIA.dbo.Person_Table WHERE (First_Name LIKE '%" + fname + "%'AND Last_Name LIKE '%" + lname + "%') ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);

            personinfo.DataSource = vbd;
            personinfo.DataBind();



            con.Close();
            personinfo.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            string id = b1.CommandArgument;
            con.Open();
            string qry1 = "select * FROM JIA.dbo.Person_Table WHERE Person_ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(qry1, con);
            SqlDataAdapter search = new SqlDataAdapter(cmd);

            DataTable a = new DataTable();
            search.Fill(a);
            editlist.DataSource = a;
            editlist.DataBind();

            string qry2 = "select * FROM JIA.dbo.Spouse_Table WHERE Person_ID = '" + id + "'";
            SqlCommand cmd1 = new SqlCommand(qry2, con);
            SqlDataAdapter search1 = new SqlDataAdapter(cmd1);

            DataTable b = new DataTable();
            search1.Fill(b);

            DataList1.DataSource = b;
            DataList1.DataBind();


            string qry3 = "select * FROM JIA.dbo.Profession_Table WHERE Person_ID = '" + id + "'";
            SqlCommand cmd2 = new SqlCommand(qry3, con);
            SqlDataAdapter search2 = new SqlDataAdapter(cmd2);

            DataTable c = new DataTable();
            search2.Fill(c);

            DataList2.DataSource = c;
            DataList2.DataBind();


            string qry4 = "select * FROM JIA.dbo.Cell_Group_Member WHERE Person_ID = '" + id + "'";
            SqlCommand cmd3 = new SqlCommand(qry4, con);
            SqlDataAdapter search3 = new SqlDataAdapter(cmd3);

            DataTable d = new DataTable();
            search3.Fill(d);

            DataList4.DataSource = d;
            DataList4.DataBind();


            con.Close();
            editlist.Visible = true;
        }

        protected void DataList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string PID = b.CommandArgument;

            foreach (DataListItem item in editlist.Items)
            {
                TextBox TextBox3 = (TextBox)item.FindControl("TextBox3");
                string Fname = TextBox3.Text;

                TextBox TextBox4 = (TextBox)item.FindControl("TextBox4");
                string Lname = TextBox4.Text;

                TextBox TextBox7 = (TextBox)item.FindControl("TextBox7");
                string nickname = TextBox7.Text;

                TextBox TextBox9 = (TextBox)item.FindControl("TextBox9");
                string Mobile1 = TextBox9.Text;

                TextBox TextBox10 = (TextBox)item.FindControl("TextBox10");
                string Mobile2 = TextBox10.Text;

                TextBox TextBox14 = (TextBox)item.FindControl("TextBox14");
                string MemberSince = TextBox14.Text;

                TextBox TextBox15 = (TextBox)item.FindControl("TextBox15");
                string city = TextBox15.Text;

                TextBox TextBox16 = (TextBox)item.FindControl("TextBox16");
                string address = TextBox16.Text;

                TextBox TextBox5 = (TextBox)item.FindControl("TextBox5");
                string Mname = TextBox5.Text;

                TextBox TextBox6 = (TextBox)item.FindControl("TextBox6");
                string MIname = TextBox6.Text;

                TextBox TextBox8 = (TextBox)item.FindControl("TextBox8");
                string Bdate = TextBox8.Text;

                TextBox TextBox11 = (TextBox)item.FindControl("TextBox11");
                string Email = TextBox11.Text;



                string Gender = Request.Form["gender"];

                TextBox TextBox17 = (TextBox)item.FindControl("TextBox17");
                string barangay = TextBox17.Text;

                TextBox TextBox18 = (TextBox)item.FindControl("TextBox18");
                string province = TextBox18.Text;

                string status = Request.Form["dropdown"];

                TextBox TextBox12 = (TextBox)item.FindControl("TextBox12");
                string KeyID = TextBox12.Text;


                con.Open();
                string sqlinsertStatement1 = @"UPDATE JIA.dbo.Person_Table SET Middle_Name = '" + Mname +
                                               "',Middle_Initial='" + MIname +
                                               "',Last_Name='" + Lname +
                                               "',First_Name='" + Fname +
                                               "',Nick_Name='" + nickname +
                                               "',Birthday='" + Bdate +
                                               "',Mobile_1='" + Mobile1 +
                                               "',Mobile_2='" + Mobile2 +
                                               "',Email='" + Email +
                                               "',Gender='" + Gender +
                                               "',Member_Since='" + MemberSince +
                                               "',Marital_Status='" + status +
                                               "',Address='" + address +
                                               "',Barangay='" + barangay +
                                               "',City='" + city +
                                               "',Province='" + address +
                                               "',KeyID='" + KeyID +
                                               "'" + "WHERE Person_ID ='" + PID + "'";
                SqlCommand cmd = new SqlCommand(sqlinsertStatement1, con);
                cmd.ExecuteNonQuery();

                con.Close();

            }

            foreach (DataListItem item1 in DataList1.Items)
            {
                con.Open();
                TextBox TextBox19 = (TextBox)item1.FindControl("TextBox19");
                string spname = TextBox19.Text;
                TextBox TextBox21 = (TextBox)item1.FindControl("TextBox21");
                string Anniversary = TextBox21.Text;

                string sqlinsertStatement2 = @"UPDATE JIA.dbo.Spouse_Table SET Spouse_Name = '" + spname +
                                            "',Anniversary='" + Anniversary +
                                            "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement2, con);
                cmdTxt1.ExecuteNonQuery();
                con.Close();
            }
            foreach (DataListItem item2 in DataList2.Items)
            {
                con.Open();
                TextBox TextBox22 = (TextBox)item2.FindControl("TextBox22");
                string Education = TextBox22.Text;
                TextBox TextBox23 = (TextBox)item2.FindControl("TextBox23");
                string Educationlvl = TextBox23.Text;
                TextBox TextBox24 = (TextBox)item2.FindControl("TextBox24");
                string Course = TextBox24.Text;
                TextBox TextBox25 = (TextBox)item2.FindControl("TextBox25");
                string Profession = TextBox25.Text;
                string sqlinsertStatement3 = @"UPDATE JIA.dbo.Profession_Table SET Education = '" + Education +
                                            "',Education_Level='" + Educationlvl +
                                            "',Course='" + Course +
                                            "',Profession='" + Profession +
                                            "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmdTxt2 = new SqlCommand(sqlinsertStatement3, con);
                cmdTxt2.ExecuteNonQuery();
                con.Close();
            }

            foreach (DataListItem item4 in DataList4.Items)
            {
                con.Open();
                TextBox TextBox26 = (TextBox)item4.FindControl("TextBox26");
                string CellLeader = TextBox26.Text;
                //TextBox TextBox27 = (TextBox)item4.FindControl("TextBox27");
                //string CellGroupName = TextBox27.Text;

                string CellGroupName = Request.Form["cellname"];

                TextBox TextBox28 = (TextBox)item4.FindControl("TextBox28");
                string CellGroupFacilitator = TextBox28.Text;

                string sqlinsertStatement3 = @"UPDATE JIA.dbo.Cell_Group_Member SET Cell_Group_Name = '" + CellGroupName +
                                            "',Cell_Leader='" + CellLeader +
                                            "',Cell_Facilitator='" + CellGroupFacilitator +
                                            "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmdTxt2 = new SqlCommand(sqlinsertStatement3, con);
                cmdTxt2.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("<script language='javascript'>window.alert('Saved');window.location='PersonInfo.aspx';</script>");
        
        }

        protected void personinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}