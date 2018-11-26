using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace JIA
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_click(object sender, EventArgs e)
        {
            string SenderName = TextBox3.Text;
            string SenderEmail = TextBox4.Text;
            string SenderPassword = TextBox6.Text;

            string RecieverName = TextBox2.Text;
            string RecieverEmail = TextBox5.Text;

            string emailsubject = TextBox7.Text;
            string emailbody = TextBox1.Text;

            var fromAddress = new MailAddress(SenderEmail, SenderName);
            var toAddress = new MailAddress(RecieverEmail, RecieverName);
             string fromPassword = SenderPassword;
             string subject = emailsubject;
             string body = emailbody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
                Response.Write("<script language='javascript'>window.alert('Message Sent');window.location='Email.aspx';</script>");

            }
        }
    }
}