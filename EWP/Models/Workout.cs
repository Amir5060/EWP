using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutID { get; set; }

        public string WorkoutName { get; set; }

        public int Difficaulty { get; set; }

    }
}