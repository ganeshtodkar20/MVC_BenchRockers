using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}