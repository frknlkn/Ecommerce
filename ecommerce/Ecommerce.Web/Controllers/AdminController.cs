using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Model;
using Ecommerce.Web.Infrastructure;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Controllers
{
    public class AdminController : BaseController
    {

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Genders.ToList());
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(GenderViewModel gender)
        {
            if (ModelState.IsValid)
            {
                var _gender = new Gender
                {
                    Name = gender.Name,
                    RecordDate= DateTime.Now,
                    RecordIsDeleted= false,
                    RecordUserId= GetUser()
                };
                db.Genders.Add(_gender);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gender);
        }
    }
}