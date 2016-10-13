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
    
    public partial class Injury
    {
        public int InjuryID { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<int> MuscleID { get; set; }
        public Nullable<int> JointID { get; set; }
        public string InjuryDescription { get; set; }
        public Nullable<int> BoneID { get; set; }
    
        public virtual Bone Bone { get; set; }
        public virtual Joint Joint { get; set; }
        public virtual Muscle Muscle { get; set; }
        public virtual User User { get; set; }
    }
}
