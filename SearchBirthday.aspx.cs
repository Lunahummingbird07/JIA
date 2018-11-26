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
    public partial class SearchBirthday : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);
        }

        protected void Button1_click(object sender, EventArgs e)
        {
            string Month = TextBox1.Text;


            con.Open();
           string qry = "DECLARE @MONTHWORD VARCHAR(30) = '" + Month
                         + "'SELECT 'Name' = First_Name + '  ' + Last_Name, Birthday, Birthday_Day = CAST(DAY(Birthday) AS VARCHAR(5)) FROM Person_Table WHERE MONTH(Birthday) = CASE WHEN @MONTHWORD = 'January' THEN 1 WHEN @MONTHWORD = 'February' THEN 2 WHEN @MONTHWORD = 'March' THEN 3 WHEN @MONTHWORD = 'April' THEN 4 WHEN @MONTHWORD = 'May' THEN 5 WHEN @MONTHWORD = 'June' THEN 6 WHEN @MONTHWORD = 'July' THEN 7 WHEN @MONTHWORD = 'August' THEN 8 WHEN @MONTHWORD = 'September' THEN 9 WHEN @MONTHWORD = 'October' THEN 10 WHEN @MONTHWORD = 'November' THEN 11 WHEN @MONTHWORD = 'December' THEN 12 END	ORDER BY DAY(Birthday)";

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