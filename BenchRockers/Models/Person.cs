using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class Person
    {
        public int PersonId { get; set; }       

        [Required]
        public string Name { get; set; }

        [Required]
        public string EmailAddress { get; set; }      

        // "M" for mail, "F" for female.
        [Required]
        public string Gender { get; set; }
       
    }
}