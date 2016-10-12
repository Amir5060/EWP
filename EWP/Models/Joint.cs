using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Joint
    {
        [Key]
        public int JointID { get; set; }

        public string JointName { get; set; }

    }
}