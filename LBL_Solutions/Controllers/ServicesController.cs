using LBL_Solutions.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace LBL_Solutions.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet]
        public IActionResult BespokeSoftware()
        {
            return View();
        }
        [HttpPost]
        public ViewResult BespokeSoftware(ContactMsgModel vm)
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
        [HttpGet]
        public IActionResult Consultancy()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Consultancy(ContactMsgModel vm)
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
        [HttpGet]
        public IActionResult AgilePrototyping()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AgilePrototyping(ContactMsgModel vm)
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
        [HttpGet]
        public IActionResult BrandingDesign()
        {
            return View();
        }
        [HttpPost]
        public ViewResult BrandingDesign(ContactMsgModel vm)
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
        [HttpGet]
        public IActionResult Infrastructure()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Infrastructure(ContactMsgModel vm)
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
        public IActionResult ServicesHome()
        {
            return View();

        }

    }
}
