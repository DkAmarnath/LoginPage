using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginPage.Models
{
    public class CityModel
    {
        [Key]
        public int Cityid { get; set; }
        public int Stateid { get; set; }
        public string CityName { get; set; }
    }
}