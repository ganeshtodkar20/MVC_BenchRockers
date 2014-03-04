using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Role")]
        [Required]
        public string Role { get; set; }

        [Display(Name = "Account")]
        [Required]
        public string Account { get; set; }

        [Display(Name = "Total Experience")]
        [Required]
        public float TotalExp { get; set; }

        [Display(Name = "Location")]
        [Required]
        public string Location { get; set; }

    }
}