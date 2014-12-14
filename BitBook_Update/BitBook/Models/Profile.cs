using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Profile
    {
        public Profile() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage="You need to enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to enter your last name.")]
        public string LastName { get; set; }

        public byte[] Picture { get; set; }

        public Guid AspNetUser_Id { get; set; }

        public string FavoriteSaying { get; set; }

        [NotMapped]
        public string FullName {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}