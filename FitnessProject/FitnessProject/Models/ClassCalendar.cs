using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessProject.Models
{

    public class ClassCalendar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public int DaysOfWeekId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Descrption { get; set; }


        public virtual DaysOfWeek DayOfWeek { get; set; }
    }

}