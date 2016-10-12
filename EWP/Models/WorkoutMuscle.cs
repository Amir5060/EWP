using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class WorkoutMuscle
    {
        [Key]
        public int WorkoutMuscleID { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutID { get; set; }

        [ForeignKey("Muscle")]
        public int MuscleID { get; set; }

        public bool PrimMover { get; set; }

        public bool Synergist { get; set; }

        public bool Stabilizer { get; set; }

        public bool Lengthening { get; set; }

        public virtual Workout Workout { get; set; }

        public virtual Muscle Muscle { get; set; }
    }
}