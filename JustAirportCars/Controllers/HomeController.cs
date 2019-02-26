using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace JustAirportCars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
      

            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }


        public ActionResult Prices()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Booking(string name ,string Phone , string email, string cabType, string date ,string Time ,string PickUp ,string DropOff ,string passengers, string direction)
        {
           

            MailMessage mm = new MailMessage("malikaamir966@gmail.com", "malikaamir966@gmail.com");
            mm.Subject = "Hi new job ! I'm  " +"\t"+name;  
            mm.Body = "Passerger Name  \t     " + "\t" + name + "\n" +
                      "Phone Number  \t       " + "\t" + Phone + "\n" +
                      "Email  \t \t  \t       " + "\t" + email + "\n" +
                      "Cab Type   \t \t    " + "\t \t" + cabType + "\n" +
                      "Date   \t\t  \t       " + "\t" + date + "\n" +
                      "Time      \t\t \t      " + "\t" +  Time + "\n" +
                      "Pickup Location \t  " + "\t" + PickUp + "\n" +
                      "Drop off location \t    " + "\t" + DropOff + "\n" +
                      "Number of passengers" + "\t \t \t" + passengers + "\n" +
                      "Direction      \t\t     " + "\t" + " \t" + direction; 


               
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("malikaamir966@gmail.com","very very cool");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Your information submitted suceessfull";
           

            return View();
        }

    }
}