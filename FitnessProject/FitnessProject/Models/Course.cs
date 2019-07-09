using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}