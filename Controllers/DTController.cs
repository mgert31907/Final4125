using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final4125.Controllers
{
    public class DTController : Controller
    {
        // GET: DT
        public ActionResult Index()
        {
            return View();
        }

        public string Today()
        {
            string datetimeNow = DateTime.Now.ToString();
            return HttpUtility.HtmlEncode("Right now is " + datetimeNow);
        }
            
    }
}