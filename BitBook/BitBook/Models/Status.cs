using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        public string StatusName { set; get; }

        

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double? Target { get; set; }

        public bool GoalType { get; set; }

       

        public int GoalStatusId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ApplicationUser User { get; set; }

        

        public virtual ICollection<Support> Supports { get; set; }

        public virtual ICollection<Update> Updates { get; set; }

        //public virtual ICollection<SupportInvitation> SupportInvitations { get; set; }


        public Status()
        {
            CreatedDate = DateTime.Now;
            GoalStatusId = 1;
        }
    }
}