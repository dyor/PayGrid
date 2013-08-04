using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using SendGridMail;
using SendGridMail.Transport;


namespace PayGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Create network credentials to access your SendGrid account.
            var username = "sendgrid@payboard.com"; // 
            var pswd = "azazoo";

            var credentials = new NetworkCredential(username, pswd);
            // Setup the email properties.
            var from = new MailAddress("matt@payboard.com");
            var to = new MailAddress[] { new MailAddress("matt@dyor.com") };
            var cc = new MailAddress[] { new MailAddress("anna@dyor.com") };
            var bcc = new MailAddress[] { new MailAddress("matt@payboard.com") };
            var subject = "Week 3 in the bag";
            var html = "<p>Hello World!</p>";
            var text = "Hello World plain text!";
            //var transport = SendGridMail.Transport.SMTP;

            // Create an email, passing in the the eight properties as arguments.
            SendGrid myMessage = SendGrid.GetInstance(from, to, cc, bcc, subject, html, text);



            var transport = Web.GetInstance(credentials);// SMTP.GetInstance(credentials, "smtp.sendgrid.net", 25);

            // Send the email.
            // uncomment transport.Deliver(myMessage);
            
            ViewBag.Message = "Getting Done";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
