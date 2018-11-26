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
    public partial class AddMember : System.Web.UI.Page
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
                con.Open();
                string Fname = TextBox3.Text;
                string Lname = TextBox4.Text;
                string Nname = TextBox7.Text;
                string Mobile1 = TextBox9.Text;
                string Mobile2 = TextBox10.Text;
                string MemberSince = TextBox14.Text;
                string City = TextBox15.Text;
                string Address = TextBox16.Text;
                string spname = TextBox19.Text;
                string Anniversary = TextBox21.Text;
                string Education = TextBox22.Text;
                string Educationlvl = TextBox23.Text;
                string Course = TextBox24.Text;
                string Profession = TextBox25.Text;
                string CellLeader = TextBox26.Text;
                string CellGroupName = Request.Form["cellname"];
                string CellGroupFacilitator = TextBox28.Text;
                string Mname = TextBox5.Text;
                string MIname = TextBox6.Text;
                string Bdate = TextBox8.Text;
                string Email = TextBox11.Text;
                string Gender = Request.Form["gender"];
                string Mstatus = Request.Form["mstat"];
                string Barangay = TextBox17.Text;
                string Province = TextBox18.Text;
                string KeyID = TextBox1.Text;



                string sqlinsertStatement1 = @"Insert Into JIA.dbo.Person_Table (First_Name, Middle_Name, Middle_Initial, 
                                                Last_Name,Nick_Name, Birthday, Mobile_1, Mobile_2, Email, Gender, Marital_Status, 
                                                Member_Since, Address, Barangay, City, Province, KeyID)
                                                Values ('" + Fname
                                                + "','" + Mname + "','"
                                                + MIname + "','"
                                                + Lname + "','"
                                                + Nname + "','"
                                                + Bdate + "','"
                                                + Mobile1 + "','"
                                                + Mobile2 + "','"
                                                + Email + "','"
                                                + Gender + "','"
                                                + Mstatus + "','"
                                                + MemberSince + "','"
                                                + Address + "','"
                                                + Barangay + "','"
                                                + City + "','"
                                                + Province + "','"
                                                + KeyID + "')";


                SqlCommand cmdTxt1 = new SqlCommand(sqlinsertStatement1, con);
                cmdTxt1.ExecuteNonQuery();

                string qry = "select * FROM JIA.dbo.Person_Table WHERE (First_Name = '" + Fname + "'AND Last_Name ='" + Lname + "') ";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                string PID = TextBox2.Text;

                string sqlinsertStatement2 = @"Insert Into JIA.dbo.Spouse_Table (Person_ID)Values ('" + PID + "')";
                SqlCommand cmdTxt2 = new SqlCommand(sqlinsertStatement2, con);
                cmdTxt2.ExecuteNonQuery();

                string sqlinsertStatement3 = @"Insert Into JIA.dbo.Profession_Table (Person_ID)Values ('" + PID + "')";
                SqlCommand cmdTxt3 = new SqlCommand(sqlinsertStatement3, con);
                cmdTxt3.ExecuteNonQuery();

                string sqlinsertStatement5 = @"Insert Into JIA.dbo.Cell_Group_Member (Person_ID)Values ('" + PID + "')";
                SqlCommand cmdTxt5 = new SqlCommand(sqlinsertStatement5, con);
                cmdTxt5.ExecuteNonQuery();


                string qry2 = @"UPDATE JIA.dbo.Spouse_Table SET Spouse_Name = '" + spname +
                                                "',Anniversary='" + Anniversary +
                                                "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmd1 = new SqlCommand(qry2, con);
                cmd1.ExecuteNonQuery();

                string qry3 = @"UPDATE JIA.dbo.Profession_Table SET Education = '" + Education +
                                                "',Education_Level='" + Educationlvl +
                                                "',Course='" + Course +
                                                "',Profession='" + Profession +
                                                "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmd2 = new SqlCommand(qry3, con);
                cmd2.ExecuteNonQuery();



                string qry4 = @"UPDATE JIA.dbo.Cell_Group_Member SET Cell_Group_Name = '" + CellGroupName +
                                                "',Cell_Leader='" + CellLeader +
                                                "',Cell_Facilitator='" + CellGroupFacilitator +
                                                "'" + "WHERE Person_ID ='" + PID + "'";

                SqlCommand cmd3 = new SqlCommand(qry4, con);
                cmd3.ExecuteNonQuery();



                con.Close();

                Response.Write("<script language='javascript'>window.alert('Saved');window.location='AddMember.aspx';</script>");
            }
            catch 
            {
                Response.Write("<script language='javascript'>window.alert('Information incorrect Please Check');window.location='CellGroup.aspx';</script>");

            }
        }
    }
}