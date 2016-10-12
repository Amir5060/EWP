using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Muscle
    {
        [Key]
        public int MuscleID { get; set; }

        public string MuscleName { get; set; }

    }
}