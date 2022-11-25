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

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Test/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                CustommerService.Custommer custommer = new CustommerService.Custommer();
                UpdateModel(custommer);
                CustommerService.Error[] errors = custommerServiceClient.AddCustommer(custommer);
                if (errors.Any())
                {
                    ViewData["Error"] = errors;
                    return View(custommer);
                }
                else
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}