using System.Collections.Generic;
using BitBook.Models;

namespace BitBook.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<NotificationsViewModel> Notification { get; set; }
        public int? Count { get; set; }
        public Profile Profile { get; set; }
        public List<Status> StatusList { get; set; }

        public List<Profile> ProfileCollection { get; set; }

    }
}