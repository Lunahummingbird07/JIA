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
    public partial class SeminarAttended : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Username"]);



            con.Open();
            string qry = " SELECT 'Name' = p.First_Name + ' ' + p.Last_Name,'GNS' = CASE WHEN Seminar_Code LIKE 'GNS%' AND sa.Person_ID IS NOT NULL THEN 'Yes' END, 'CLC' = CASE WHEN Seminar_Code LIKE 'CLC%' AND sa.Person_ID IS NOT NULL THEN 'Yes' END,'SOW1' = CASE WHEN Seminar_Code LIKE 'SOW1%' AND sa.Person_ID IS NOT NULL THEN 'Yes' END,'SOW2' = CASE WHEN Seminar_Code LIKE 'SOW2%' AND sa.Person_ID IS NOT NULL THEN 'Yes' END FROM Person_Table p LEFT JOIN seminar_attendees sa ON p.Person_ID = sa.Person_ID";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter viewbd = new SqlDataAdapter(cmd);
            DataTable vbd = new DataTable();
            viewbd.Fill(vbd);

            GridView1.DataSource = vbd;
            GridView1.DataBind();




            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}