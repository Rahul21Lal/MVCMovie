using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ 
        public ActionResult Index()
        {
            return View();
        }
        

        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, string numTimes)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}