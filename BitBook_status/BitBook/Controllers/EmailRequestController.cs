using System;
using System.Web.Mvc;
using BitBook.Models;
using Microsoft.AspNet.Identity;

namespace BitBook.Controllers
{
    public class EmailRequestController : Controller
    {
          private readonly IBitSecurityTokenService securityTokenService;
        //
        // GET: /EmailRequet/
        public ActionResult AddGroupUser()
        {
            Guid groupIdToken = (Guid)TempData["grToken"];
            var groupId = securityTokenService.GetActualId(groupIdToken);
            GroupUser newGroupUser = new GroupUser()
            {
                UserId = User.Identity.GetUserId(),
                GroupId = groupId,
                Admin = false
            };
            BitBookSessionFacade.Remove(BitBookSessionFacade.JoinGroupOrGoal);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddSupportToGoal()
        {
            Guid goalIdToken = (Guid)TempData["goToken"];
            var goalId = securityTokenService.GetActualId(goalIdToken);
            //supportService.CreateSupport(new Support() { UserId = User.Identity.GetUserId(), StatusId = goalId, SupportedDate = DateTime.Now });
            //securityTokenService.DeleteSecurityToken(goalIdToken);
            
            return RedirectToAction("Index", "Home");
        }
    }
}