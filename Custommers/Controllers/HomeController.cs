using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custommers.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustommerService.ICustommerService custommerServiceClient;
        public HomeController()
        {
            this.custommerServiceClient = new CustommerService.CustommerServiceClient();
        }
        public ActionResult Index()
        {
            CustommerService.Custommer[] custommers = custommerServiceClient.GetCustommers();
            return View(custommers);
        }
    }
}