using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class BitBookSessionFacade
    {
        private const string joinGroupOrGoal = "JoinGroupOrGoal";


        public static string JoinGroupOrGoal
        {
            get
            {
                return (string)HttpContext.Current.Session[joinGroupOrGoal];
            }

            set
            {
                HttpContext.Current.Session[joinGroupOrGoal] = value;
            }
        }

        public static void Remove(string sessionVariable)
        {
            HttpContext.Current.Session.Remove(sessionVariable);
        }

        public static void Clear()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}