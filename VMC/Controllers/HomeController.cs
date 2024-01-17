using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Services;
using VMC.Models;

namespace VMC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult kutse()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 10 ? "Tere hommikust" : "Tere päevast";//hour<10? = if(hour < 10) / : = else
            ViewBag.Message = "Ootan sind oma peole. Tule kindlasti! Ootan sind!";
            return View();
        }

        [HttpGet]
        public ActionResult ankeet()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ankeet(guest Gosling)
        {
            E_mail(Gosling);
            if (ModelState.IsValid)
            {
                return View("Thanks", Gosling);
            }
            else
            {
                return View();
            }
            
        }

        public void E_mail(guest Gosling)
        {
            try
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 587;
                WebMail.EnableSsl= true;
                WebMail.UserName = "goslingrayan925@gmail.com";
                WebMail.Password= "wezm cjak kfkm hvcp ";
                WebMail.From = "goslingrayan925@gmail.com";
                WebMail.Send("martinnm84@gmail.com", "Vastus kutsele", Gosling.Name + " vastus " + ((Gosling.WillAttend ?? false) ? "tuleb peole " : "ei tule peole"));
                ViewBag.Message = "Kiri on saatnud!";

            }
            catch (Exception)
            {
                ViewBag.Message = "Mul on kahju! Ei saa kirja saada!!!";
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}