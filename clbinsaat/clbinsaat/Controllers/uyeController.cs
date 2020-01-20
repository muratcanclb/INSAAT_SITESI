
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;
using clbinsaat.Data.Context;

namespace clbinsaat.Controllers
{
    public class uyeController : Controller
    {
        // GET: uye
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(clbinsaat.Data.user userModel)
        {
     
            using (clbContext db = new clbContext())
            {
                var userDetails = db.users.Where(x => x.userName == userModel.userName && x.userPass == userModel.userPass).FirstOrDefault();
                if(userDetails == null)
                {
                    return View("Index", userModel);
                }
                else
              
                    Session["userID"] = userDetails.userID;
                    return RedirectToAction("Index", "Home");
                }
            }
      
        }
    }
