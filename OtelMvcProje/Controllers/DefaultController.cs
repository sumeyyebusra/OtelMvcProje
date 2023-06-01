using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using OtelMvcProje.Models.Entity;


namespace OtelMvcProje.Controllers
{

    
    public class DefaultController : Controller
    {
        // GET: Default

        //DbOtelYeniEntities dbOtel = new DbOtelYeniEntities();
        public ActionResult Hakkimizda()
        {
            
            //var veriler = dbOtel.TblHakkimda.ToList();
            return View();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}