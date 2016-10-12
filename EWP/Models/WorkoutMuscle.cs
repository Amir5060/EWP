using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class WorkoutMuscle
    {
        [Key]
        public int WorkoutMuscleID { get; set; }

        public int WorkoutID { get; set; }

        public int MuscleID { get; set; }

        public bool PrimMover { get; set; }

        public bool Synergist { get; set; }

        public bool Stabilizer { get; set; }

        public bool Lengthening { get; set; }

    }
}