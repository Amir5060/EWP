using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Injury
    {
        [Key]
        public int InjuryID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Muscle")]
        public int MuscleID { get; set; }

        [ForeignKey("Joint")]
        public int JointID { get; set; }

        [ForeignKey("Bone")]
        public int BoneID { get; set; }

        public string InjuryDescription { get; set; }

        public virtual User User { get; set; }

        public virtual Muscle Muscle { get; set; }

        public virtual Joint Joint { get; set; }

        public virtual Bone Bone { get; set; }


    }
}