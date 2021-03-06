﻿using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using HealthUp.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthUp.Web.Controllers
{
    public class StoryController : Controller
    {
        // GET: /<controller>/

        EmailService email;

        public StoryController()
        {
            email = new EmailService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string SendEmail(string Name, string Email, string Message)
        {
            try
            {
                var addr = new EmailAddressAttribute();
                if (Name == null)
                {
                    return "Please Enter Your Name.";
                }
                if(Email == null)
                {
                    return "Please Enter Your Email Address.";
                }
                else if(!addr.IsValid(Email))
                {
                    return "Please Check your email address Again.";
                }

                if(Message == null)
                {
                    return "Please Enter Message to HealUp.";
                }
                // Credentials
                var credentials = new NetworkCredential("healthup777@gmail.com", "zxrxzksgibimryik");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress(Email),                    
                    Subject = "Health Up Inquiry from : " + Name,
                    Body = "Name : " + Name + "<br />" + "Email : " + Email + "<br />" + "Message : " + Message
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress("info@healthup.co.nz"));
                mail.CC.Add(new MailAddress("healthup777@gmail.com"));
                // Smtp client
                var client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,                  
                    Credentials = credentials,
                    EnableSsl = true
                };

                client.Send(mail);
                return "Your Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
        }
    }
}
