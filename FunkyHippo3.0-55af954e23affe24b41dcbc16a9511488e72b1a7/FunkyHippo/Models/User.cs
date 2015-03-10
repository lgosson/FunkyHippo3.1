using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FunkyHippo.Models
{
    public class User : IEntityModel
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string SurName { get; set; }
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        

        public virtual ICollection<Review> Reviews { get; set; }
    }
}