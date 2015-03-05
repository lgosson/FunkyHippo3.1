using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.Models
{
    public class ReviewViewModel
    {
        private int ID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public UserViewModel UserName { get; set; }
    }

    public class UserViewModel
    {
        public string UserName{get; set;}

    }
}