//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EWP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class C1RMWorkout
    {
        [Key]
        public int RMWorkoutID { get; set; }
        public int RMID { get; set; }
        public int WorkoutID { get; set; }
        public Nullable<int> WorkoutWeight { get; set; }
        public Nullable<int> Repetition { get; set; }
        public Nullable<System.DateTime> RMWorkoutDate { get; set; }
    
        public virtual C1RM C1RM { get; set; }
        public virtual Workout Workout { get; set; }
    }
}
