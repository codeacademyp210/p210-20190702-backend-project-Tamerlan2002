using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public class AllViewModel
    {
        public List<CourseSchedule> CourseSchedules { get; set; }
        public List<Info> Infos { get; set; }
        public List<Package> Packages { get; set; }
    }
}