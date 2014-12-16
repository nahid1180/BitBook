using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class ProfileStatus
    {
        public int ProfileStatusId { set; get; }
     // public Profidasdafile { get; set; }
        public List<Status> StatusList { get; set; }

        public List<Profile> ProfileCollection { get; set; }
    }
}