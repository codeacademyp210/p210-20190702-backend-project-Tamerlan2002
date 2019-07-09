using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessProject.Models
{


    public class CourseSchedule
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int DayOfWeekId { get; set; }
        public int RoomId { get; set; }
        public int TrainerId { get; set; }
        public int CourseId { get; set; }
        [AllowHtml]
        public string Description { get; set; }

        public virtual Course Course { get; set; }
        public virtual Room Room { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual DaysOfWeek DayOfWeek { get; set; }
    }
}