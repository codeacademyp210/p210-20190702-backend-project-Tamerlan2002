using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public enum Status
    {
        Active = 1,
        Pending = 2,
        Blocked = 3
    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Gender GenderOfUser { get; set; }
        public DateTime DateOfBirith { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public Status StatusOfUser { get; set; }
        public Course CourseId { get; set; }
        public Trainer TrainerId { get; set; }
        public double MoneyPaid { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}