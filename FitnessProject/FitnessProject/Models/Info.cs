using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        [Display(AutoGenerateField = false)]
        public string Password { get; set; }
    }
}