using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WDVACandidateProject.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        [Required]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        [Required]
        public string lastName { get; set; }

        [Display(Name = "Address")]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9 ]*$")]
        public string address { get; set; }

        [Display(Name = "City")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        [Required]
        public string city { get; set; }

        [Display(Name = "State")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        [Required]
        public string state { get; set; }

        [Display(Name = "5 Digit Zip Code")]
        [Required]
        [RegularExpression(@"^[0-9 ]*$")]
        public int zip { get; set; }

        [Display(Name = "Email")]
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string email { get; set; }

        [Display(Name = "Age")]
        [Required]
        public int age { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string gender { get; set; }

        [Display(Name = "Education")]
        [Required]
        public string education { get; set; }

        [Display(Name = "Race")]
        [Required]
        public string race { get; set; }

        [Display(Name = "Marital Status")]
        [Required]
        public string maritalStatus { get; set; }
    }

    public class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}