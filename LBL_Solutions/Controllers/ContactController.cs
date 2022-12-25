using LBL_Solutions.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace LBL_Solutions.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ContactForm(ContactMsgModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting 
                                                         //from contact us page 
                    msz.To.Add("brandenconnected@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message + "FROM: " + vm.Name + " Address: " + vm.Email;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                    ("brandenconnected@gmail.com", "txjuylcflfhjszpl");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us " + vm.Name;
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
                return View();
            }
            return View();
        }
        public IActionResult ContactSuccess()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
    