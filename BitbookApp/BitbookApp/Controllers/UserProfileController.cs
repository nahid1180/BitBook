using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitbookApp.Models;

namespace BitbookApp.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
      

        public ActionResult UserProfile()
        {
            return View();
        }
    
}
}