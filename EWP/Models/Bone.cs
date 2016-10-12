using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public class Bone
    {
        [Key]
        public int BoneID { get; set; }

        public string BoneName { get; set; }
    }
}