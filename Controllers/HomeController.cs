using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dev.CRM.Business;
using System.Threading;

namespace Dev.CRM.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //IArticleManage ArticleManage;

        //public HomeController(IArticleManage articleManage)
        //{
        //  //  ArticleManage = articleManage;
        //}

        public ActionResult Index()
        {
           // var list = ArticleManage.GetArchiveByAlais();
          //  ViewBag.Message = "欢迎使用 ASP.NET MVC!" + list[0].Title;

            return View();
        }

        public ActionResult Main()
        {
            return View();
        }

        public string List()
        {
            Thread.Sleep(5000);
            return "View()";
        }
    }
}
