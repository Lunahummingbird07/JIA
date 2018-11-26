using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using ASPSnippets.SmsAPI;

namespace JIA
{
    public partial class SMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_click(object sender, EventArgs e)
        {

            String result;
            string apiKey = "kP+gqz9TSbw-qx3jFXIdaVIO6VsurXBlxayfKj9gjE";
            string numbers = txtRecepientNumber.Text;
            string message = txtMessage.Text;
            string Sender = txtSender.Text;

            String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + Sender;

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            //objRequest.ContentLength = System.Text.Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";


            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch
            {
                //return e.Message;
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            //return result;
            Response.Write("<script language='javascript'>window.alert('Message Sent');window.location='SMS.aspx';</script>");

//----------------------------------------------------------------------------




            }

        }
    }
