using FitnessProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitnessProject.DAL
{
    public class TemplateContext : DbContext
    {
        public TemplateContext() : base("TemplateContext")
        { 
        }

        public DbSet<ClassCalendar> ClassCalendars { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DaysOfWeek> DaysOfWeeks { get; set; }


    }
}