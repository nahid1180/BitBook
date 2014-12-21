using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitBook.Models;

using Microsoft.AspNet.Identity;

namespace BitBook.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private ProfileDb db = new ProfileDb();
        private ApplicationDbContext UserDB = new ApplicationDbContext();

        // GET: /Profile/
        public ActionResult Index()
        {
            var currentUser = UserDB.Users.Find(User.Identity.GetUserId());
            if (currentUser.MadeProfileYet)
            {
                var vm = new ProfileStatus();
                vm.StatusList = new List<Status>();

                Guid UserId = new Guid(User.Identity.GetUserId());
                var profile = db.UserProfiles.FirstOrDefault(x => x.AspNetUser_Id == UserId);
                vm.Profile = profile;
                //var listOfAllStatuses = db.Statuses.ToList();
                //var listOfUserStatus = new List<Status>();
                //foreach (Status x in listOfAllStatuses)
                //{
                //    if (x.UserWhomStatusBelongsTo == profile.Id) listOfUserStatus.Add(x);
                //}

                //foreach (var entry in listOfUserStatus)
                //    vm.StatusList.Add(entry);
                //if (vm.StatusList.Count == 0)
                //{
                //    Status firstStatus = new Status();
                //    Profile aProfile = new Profile();
                //    firstStatus.StatusUpdate = "Welcome!";
                //    //firstStatus.TimeOfUpdate = DateTime.Now;
                //    firstStatus.UserWhomStatusBelongsTo = aProfile.AspNetUser_Id;
                //    firstStatus.UpdatedByFullName = aProfile.FullName;
                //    db.Statuses.Add(firstStatus);
                //    vm.StatusList.Add(firstStatus);
                //    db.SaveChanges();
                //    //vm.StatusList.Add(new Status { StatusUpdate = "Welcome!", UserWhomStatusBelongsTo = profile.Id, UpdatedByFullName = profile.FullName, TimeOfUpdate = DateTime.Now });
                //}

                return View(vm);
            }
            else
                return RedirectToAction("CreateProfile");
        }

        //GET
        public ActionResult CreateProfile()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile([Bind(Include = "Id, FirstName, LastName")] Profile profile, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ImageFile.InputStream.CopyTo(ms);
                        profile.Picture = ms.GetBuffer();
                    }
                }
                profile.Id = Guid.NewGuid();
                db.UserProfiles.Add(profile);
                db.SaveChanges();

                var currentUser = UserDB.Users.Find(User.Identity.GetUserId());
                currentUser.MadeProfileYet = true;
                UserDB.SaveChanges();

                db.UserProfiles.Find(profile.Id).AspNetUser_Id = new Guid(currentUser.Id);
                db.UserProfiles.Find(profile.Id).FavoriteSaying = UserDB.Users.Find(currentUser.Id).FavoritePhrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        public ActionResult GetImage(Guid id)
        {
            byte[] imageData = db.UserProfiles.Find(id).Picture;
            return File(imageData, "image/jpeg");
        }

        

        //GET
        public ActionResult EditImage(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.UserProfiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View((Guid)id);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditImage(Guid? id, HttpPostedFileBase imageFile)
        {
            if (id != null && imageFile != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageFile.InputStream.CopyTo(ms);
                    db.UserProfiles.Find(id).Picture = ms.GetBuffer();
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View((Guid)id);
        }

        //GET
        public ActionResult Friends(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.UserProfiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            var vm = new ProfileStatus();
            vm.StatusList = new List<Status>();
            vm.ProfileCollection = new List<Profile>();
            vm.ProfileCollection = db.UserProfiles.ToList();
            vm.ProfileCollection.Remove(profile);
            vm.StatusList = db.Statuses.ToList();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LeaveMessage(Guid FriendId, string MsgForFriend)
        {
            var currentUserId = new Guid(User.Identity.GetUserId());
            Profile currentUserProfile = db.UserProfiles.FirstOrDefault(x => x.AspNetUser_Id == currentUserId);
            Profile profileOfFriend = db.UserProfiles.FirstOrDefault(x => x.Id == FriendId);
            Status statusUpdate = new Status();

            if (String.IsNullOrWhiteSpace(MsgForFriend))
                return RedirectToAction("Friends", new { id = currentUserProfile.Id });
            statusUpdate.StatusUpdate = MsgForFriend;
            statusUpdate.UpdatedByFullName = currentUserProfile.FullName;
            statusUpdate.UserWhomStatusBelongsTo = profileOfFriend.Id;
            //statusUpdate.TimeOfUpdate = DateTime.Now;
            db.Statuses.Add(statusUpdate);
            db.SaveChanges();
            return RedirectToAction("Friends", new { id = currentUserProfile.Id });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                UserDB.Dispose();
            }
            base.Dispose(disposing);
        }

        
    }
}
