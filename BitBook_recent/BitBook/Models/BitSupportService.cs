//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace BitBook.Models
//{
//    public interface ISupportService
//    {
//        IEnumerable<Support> GetSupports();
//        IEnumerable<Support> GetSupports(IEnumerable<int> id);
//        Support GetSupport(int id);
//        IEnumerable<Support> GetSupporForGoal(int goalId);
//        IEnumerable<Status> GetUserSupportedStatus(string userid, BitSupportService bitService);
//        bool CanInviteUser(string userId, int goalId);
//        IEnumerable<Support> GetTop20SupportsOfFollowings(string userId);
//        IEnumerable<Support> GetTop20Support(string userid);
//        void CreateSupport(Support support);
//        void DeleteSupport(int id);
//        bool IsStatusSupported(int statusid, string userid);
//        void DeleteSupport(int statusid, string userid);
//        void SaveSupport();
//        IEnumerable<ApplicationUser> SearchUserToSupport(string searchString, int goalId, IUserService userService, ISupportInvitationService supportInvitationService, string userid);

//        void CreateUserSupport(Support support, ISupportInvitationService supportInvitationService);

//        IEnumerable<ApplicationUser> GetSupportersOfGoal(int id, IUserService userService);
//    }

//    public class BitSupportService : ISupportService
//    {
//        public IEnumerable<Support> GetSupports()
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Support> GetSupports(IEnumerable<int> id)
//        {
//            throw new NotImplementedException();
//        }

//        public Support GetSupport(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Support> GetSupporForGoal(int goalId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Status> GetUserSupportedStatus(string userid, BitSupportService bitService)
//        {
//            throw new NotImplementedException();
//        }

//        public bool CanInviteUser(string userId, int goalId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Support> GetTop20SupportsOfFollowings(string userId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Support> GetTop20Support(string userid)
//        {
//            throw new NotImplementedException();
//        }

//        public void CreateSupport(Support support)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteSupport(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public bool IsStatusSupported(int statusid, string userid)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeleteSupport(int statusid, string userid)
//        {
//            throw new NotImplementedException();
//        }

//        public void SaveSupport()
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<ApplicationUser> SearchUserToSupport(string searchString, int goalId, IUserService userService,
//            ISupportInvitationService supportInvitationService, string userid)
//        {
//            throw new NotImplementedException();
//        }

//        public void CreateUserSupport(Support support, ISupportInvitationService supportInvitationService)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<ApplicationUser> GetSupportersOfGoal(int id, IUserService userService)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}