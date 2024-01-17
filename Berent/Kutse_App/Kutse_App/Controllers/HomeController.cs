using Kutse_App.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Kutse_App.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            ViewBag.Message = "Ootan sind minu peole! Palun tule!!!";
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 10 ? "Tere hommikust! " : "Tere päevast!";
            return View();
        }
        [HttpGet]
        public ViewResult Ankeet()
        {
            return View();
        }
        [HttpGet]
        public ViewResult About()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Piduinfo()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Ankeet(Guest guest)
        {
            E_mail(guest);
            if(ModelState.IsValid)
            {
                return View("Thanks", guest); 
            }
            else 
            {
                return View();
            }
        }

        public void E_mail(Guest guest)
        {
            try
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 465;
                WebMail.EnableSsl = true;
                WebMail.UserName = "edaktex@gmail.com";
                WebMail.Password = "woki qsun gbmt qrfa";
                WebMail.From = "edaktex@gmail.com";
                WebMail.Send(guest.Email , "Vastus kutsele", guest.Name + " vastas ", ((guest.WillAttend ?? false) ?
                    "tuleb peole " : "ei tule peole"));
                ViewBag.Message = "Kiri on saatnud!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Mul on kahju! Ei saa kirja saada!!!" + ex.Message;
            }
        }
    }
}