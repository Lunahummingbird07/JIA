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
    public partial class SearchMemberSince : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            string StartDate = TextBox1.Text;
            string EndDate = TextBox2.Text;

            con.Open();
            string qry = "DECLARE @STARTDATE DATE = '" + StartDate
                        + "'DECLARE @ENDDATE DATE = '" + EndDate
                        + "'SELECT First_Name + ' ' + Last_Name as Name, Member_Since as [Member Since] FROM person_table WHERE Member_Since BETWEEN @STARTDATE AND @ENDDATE ORDER BY [Member Since]";
            
           
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);

            GridView1.DataSource = vbd;
            GridView1.DataBind();




            con.Close();
        }
    }
}