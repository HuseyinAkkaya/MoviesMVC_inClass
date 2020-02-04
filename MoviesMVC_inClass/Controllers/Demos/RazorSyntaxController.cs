using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC_inClass.Controllers.Demos
{
    public class RazorSyntaxController : Controller
    {
        // GET: RazorSyntax
        public ActionResult Index()
        {
            return View();
        }
    }

    public static class NameUtil
    {
        public static string GetName()
        {
            return "Name: Hüseyin AKKAYA";
        }
    }
}