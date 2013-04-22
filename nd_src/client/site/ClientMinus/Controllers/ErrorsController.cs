using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientMinus.Controllers
{
    public class ErrorsController : Controller
    {
        //
        // GET: /Errors/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error505()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }
    }
}
