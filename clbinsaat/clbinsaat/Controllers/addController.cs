using clbinsaat.Data;
using clbinsaat.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clbinsaat.Controllers
{
    public class addController : Controller
    {
        // GET: add
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            clbContext db = new clbContext();
            user model = new user();
            model.userName = form["userName"].Trim();
            model.userPass = form["userPass"].Trim();

            db.users.Add(model);
            db.SaveChanges();
            return View();
        }
    }
}