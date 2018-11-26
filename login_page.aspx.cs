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
    public partial class login_page : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            Session ["Username"]  = username;



            try{
                        string uid = TextBox1.Text;
                        string pass = TextBox2.Text;  
                        string account = Request.Form["account"];
                        
                        con.Open();
                        if(account == "Admin")
                        {
                                string qry = "select * from log_in where [User_Name]='" + uid + "'and [Password]='" + pass + "' and Account='" + account + "'";  
                                SqlCommand cmd = new SqlCommand(qry,con);  
                                SqlDataReader sdr = cmd.ExecuteReader();  
                                if(sdr.Read())  
                                {  
                            
                                    Response.Write("<script language='javascript'>window.alert('Login Successful');window.location='PersonInfo.aspx';</script>");
                                }  
                                else  
                                {  
                            
                                    Page.ClientScript.RegisterStartupScript(this.GetType(),"ErrorAlert","alert('Incorrect Username or Password');",true);

  
                                }   

                        }
                        if(account == "Member")
                        {
                             string qry = "select * from log_in where [User_Name]='" + uid + "'and [Password]='" + pass + "' and Account='" + account + "'";  
                                SqlCommand cmd = new SqlCommand(qry,con);  
                                SqlDataReader sdr = cmd.ExecuteReader();  
                                if(sdr.Read())  
                                {  
                            
                                    Response.Write("<script language='javascript'>window.alert('Login Successful');window.location='MemberMainPage.aspx';</script>");
                                }  
                                else  
                                {  
                                    Page.ClientScript.RegisterStartupScript(this.GetType(),"ErrorAlert","alert('Incorrect Username or Password');",true);
                                }  
                        }
        
                            con.Close();  
                        }  
                        catch(Exception ex)  
                        {  
                            Response.Write(ex.Message);  
                            }  
                }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("RegisterAccount.aspx");
        }
        }
    }