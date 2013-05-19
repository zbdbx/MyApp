using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dev.CRM.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

    }
}
