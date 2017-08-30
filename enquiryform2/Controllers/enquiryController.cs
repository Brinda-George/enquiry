
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Net.Mail;
using enquiryform2.datacontext;
using enquiryform2.Models;
namespace enquiryform.Controllers
{
    public class enquiryController : Controller
    {
        public ActionResult Index()
        {
           
            enquiry ob = new enquiry();
            return View();
        }
        [HttpPost]
        public ActionResult Index(enquiry ob)
        {
            if (ModelState.IsValid)
            {
                using (var context = new context())
                {
                    context.customerenquiry.Add(ob);
                    context.SaveChanges();
                }
                MailMessage mail = new MailMessage();
                MailMessage mail1 = new MailMessage();
                string from = "manjurose.mec@gmail.com";
                mail.To.Add(new MailAddress(ob.Email));
                mail1.To.Add(new MailAddress(from));
                mail.From = new MailAddress(from);
                mail1.From = new MailAddress(from);
                mail.Subject = "Apple macbook pro 2016";
                mail1.Subject = "New Preorder request";
                string Body = "<h3 style='color:brown'> " + "Hai " + ob.Name + "<br />" + "<br />" + "Thankyou for showing interest in our product. We will contact you soon." + "</h3>";
                mail.Attachments.Add(new Attachment(@"C:\Users\trainee\Downloads\AppleMacTips.pdf"));
                mail.Body = Body;
                mail.IsBodyHtml = true;
                string Body1 ="<h3>"+ "From  " + ob.Email + "<br />" + "<br />" + ob.Comments+"</h3>";
                mail1.Body = Body1;
                mail1.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("manjurose.mec@gmail.com", "ROSEMANJU");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                smtp.Send(mail1);
                Response.Write("<script>alert('Mail sent successfully')</script>");
                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}