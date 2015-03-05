using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FunkyHippo.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AlbumID { get; set; }

        [RegularExpression(@"(^[1-9]$)|(^10$)")]
        public int Rating { get; set; }
        
        [StringLength(140, ErrorMessage = "Comment cannot be longer than 140 characters.")]
        public string Comment { get; set; }
        
       

        public virtual Album Album { get; set; }
        public virtual User User { get; set; }
    }
}