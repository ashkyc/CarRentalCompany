using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarCompany.Controllers
{
    public class CarsController : Controller
    {


        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
    }
}