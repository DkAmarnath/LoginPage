using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPage.Controllers
{
    public class LoginController : Controller
    {
        //private const string V = "Amarnathaa";

        // GET: Login
        public ActionResult Index()
        {
            DAL db = new DAL();

            var a= db.CityModel.ToList();
            return View();
        }
    }
}