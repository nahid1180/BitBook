using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBookMVC.Models;
using BitBookMVC.Models.Gateway;

namespace BitBookMVC.Controllers
{
    public class BitBookController : Controller
    {
        UserRegistrationGateway aGateway = new UserRegistrationGateway();
        //
        // GET: /BitBook/
        public ActionResult Index(UserProfile aProfile)
        {
            return View();
        }
	}
}