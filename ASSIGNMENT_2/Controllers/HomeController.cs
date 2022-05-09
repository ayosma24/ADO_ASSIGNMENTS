using BusAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusAssignment.Controllers
{
    public class HomeController : Controller
    {
        TravelDbContext context = new TravelDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(context.Travels);
        }


        [HttpPost]
        public ViewResult Index(Travel model)
        {
            //Code to save the customer data here
            ViewData["error"] = "Customer Data Update successfully";
            return View();
        }

        public ActionResult Create()
        {
            return View();

        }
        
        public ActionResult CreateAccount(Travel model)
        {
            context.Travels.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}