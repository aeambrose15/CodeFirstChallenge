using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstChallenge.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Name is a required field")]
        public string Name { get; set; }

        [Required]
        public string RegNo { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
       
        [Required]
        public string Address { get; set; }
    }
}