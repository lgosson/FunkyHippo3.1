using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.Models
{
    public class ReviewViewModel
    {
        
        public string Title { get; set; }
        public string Artist { get; set; }
        public RViewModel Album { get; set; }
    }

    public class RViewModel
    {
        public string UserName{get; set;}
        public int Rating { get; set; }

    }
}