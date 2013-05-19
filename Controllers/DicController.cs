using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dev.CRM.Business;
using Dev.CRM.WebUI.App_Code;

namespace Dev.CRM.WebUI.Controllers
{
    public class DicController : Controller
    {
        //
        // GET: /Dic/ge

        IDicManage DicManage { get; set; }

        public DicController(IDicManage dicManage)
        {
            DicManage = dicManage;
        }

        public ActionResult Index()
        {
            var DicType = DicManage.GetAllDicType(0);
            return View(DicType);
        }

        public ActionResult Edit(string alais)
        {
            return View();
        }

        [AjaxException]
        public string Industry()
        {
         //   throw new Exception("asdf");
            return "Industry";
        }

    }
}
