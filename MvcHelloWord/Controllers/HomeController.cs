using MvcHelloWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHelloWord.Controllers
{
    public class HomeController : Controller
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {
            int next = new Random().Next(1, 100);

            ViewBag.index = next < 40 ? "hello niuniu" : "hello lyce";
            return View();
        }


        public string SendInforomation(Person person)
        {
            return "Thanks you " + person.Name;
        }

    }
}
