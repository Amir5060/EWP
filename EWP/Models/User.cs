using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public int Height { get; set; }

        public int Experience { get; set; }

        public int SportID { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }

        public bool EmailConfirmation { get; set; }
    }
}