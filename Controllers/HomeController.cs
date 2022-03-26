using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FireBase_Authentication_MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static string ApiKey = "AIzaSyCueTS1T1xivCdGRAidY6mzzhuNx6z_AiI";
        private static string AuthEmail = "";
        private static string AuthPassword = "";
        private static string Bucket = "https://lowsaltnet-default-rtdb.firebaseio.com";
        public ActionResult Index()
        {
            return View();
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