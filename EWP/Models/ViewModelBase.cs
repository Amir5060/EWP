using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EWP.Models
{
    public abstract class ViewModelBase
    {
        public string CurrerntUserID { get; set; }
    }

    public class HomeViewModel : ViewModelBase
    {

    }    
}