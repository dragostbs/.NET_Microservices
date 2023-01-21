using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custommers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceProxy.CustommerServiceProxy custommerServiceProxy;
        public HomeController()
        {
            // Initialize proxy
            this.custommerServiceProxy = new ServiceProxy.CustommerServiceProxy();
        }
        public ActionResult Index()
        {
            ServiceProxy.Custommer[] custommers = custommerServiceProxy.GetCustommers();

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
                ServiceProxy.Custommer custommer = new ServiceProxy.Custommer();
                UpdateModel(custommer);
                ServiceProxy.Error[] errors = custommerServiceProxy.AddCustommer(custommer);

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