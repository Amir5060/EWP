using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Injury
    {
        public int InjuryID { get; set; }

        public int UserID { get; set; }

        public int MuscleID { get; set; }

        public int JointID { get; set; }

        public int BoneID { get; set; }

        public string InjuryDescription { get; set; }

        
    }
}