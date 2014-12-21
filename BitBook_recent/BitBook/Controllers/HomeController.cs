using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBook.Models;

namespace BitBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditStatus(Guid? id, string statusUpdate)
        //{
        //    if (id != null && !String.IsNullOrWhiteSpace(statusUpdate))
        //    {
        //        Status Update = new Status();
        //        var user = db.UserProfiles.Find(id);
        //        Update.StatusUpdate = statusUpdate;
        //        Update.UpdatedByFullName = user.FullName;
        //        Update.UserWhomStatusBelongsTo = user.Id;
        //        Update.TimeOfUpdate = DateTime.Now;

        //        db.Statuses.Add(Update);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(id);
        //}
    }
}