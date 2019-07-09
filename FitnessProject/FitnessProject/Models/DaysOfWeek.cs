using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{
    public class DaysOfWeek
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<ClassCalendar> ClassCalendars { get; set; }
    }
}