namespace FitnessProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FitnessProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FitnessProject.DAL.TemplateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FitnessProject.DAL.TemplateContext context)
        {
            context.Infos.AddOrUpdate(x => x.Id,
                new Info { Id = 1, Username = "Nataliapery", Email = "Nataliapery@example.com", Phone = "	999-999-9999",
                    Adress = "Sydney, Australia", City = "Nakia", Pincode = "999999", Fax = "12345", Website = "https://www.example.com",
                    Password = "AOpYOlG7M0JvRIQh2WJuFQ/i3QY3rdViyp8hYPjDFDMZsH3o60AABJJeJ1i7VpYjyA=="
                }
                );

            context.Packages.AddOrUpdate(x => x.Id,
                new Package() { Id = 1, PackageName = "Aerobics", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", StartTime = DateTime.Parse("01-01-2019"), EndTime = DateTime.Parse("02-01-2019") },
                new Package() { Id = 2, PackageName = "BodyBuilding", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", StartTime = DateTime.Parse("01-01-2019"), EndTime = DateTime.Parse("03-01-2019") },
                new Package() { Id = 3, PackageName = "Fitness", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", StartTime = DateTime.Parse("01-01-2019"), EndTime = DateTime.Parse("02-01-2019") },
                new Package() { Id = 4, PackageName = "Yoga", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", StartTime = DateTime.Parse("01-01-2019"), EndTime = DateTime.Parse("04-01-2019") }

                );
            context.Courses.AddOrUpdate(x => x.Id,
                 new Course() { Id = 1, Name = "Aerobics", Price = "70", Duration = 3, Description = "Lorem ipsum" },
                 new Course() { Id = 2, Name = "Body Building", Price = "70", Duration = 3, Description = "Lorem ipsum" },
                 new Course() { Id = 3, Name = "Fitness", Price = "70", Duration = 3, Description = "Lorem ipsum" },
                 new Course() { Id = 4, Name = "Flexibility", Price = "70", Duration = 3, Description = "Lorem ipsum" },
                 new Course() { Id = 5, Name = "Yoga", Price = "70", Duration = 3, Description = "Lorem ipsum" }
                );

            context.Rooms.AddOrUpdate(x => x.Id,
                 new Room { Id = 1, Name = "Room-A" },
                 new Room { Id = 2, Name = "Room-B" },
                 new Room { Id = 3, Name = "Room-C" },
                 new Room { Id = 4, Name = "Room-D" },
                 new Room { Id = 5, Name = "Room-E" }
                );

            context.Trainers.AddOrUpdate(x => x.Id,
                 new Trainer { Id = 1, Name = "Alex Krasnov" },
                 new Trainer { Id = 2, Name = "Alexande Bergunov" },
                 new Trainer { Id = 3, Name = "Amanda Bale" },
                 new Trainer { Id = 4, Name = "Rachel Adams" },
                 new Trainer { Id = 5, Name = "Rachel Adams" }
                );


            context.Coupons.AddOrUpdate(x => x.Id,
                 new Coupon { Id = 1, CouponName = "Aerobics" , StartTime = DateTime.Parse("01-01-2019"), FinishTime = DateTime.Parse("01-04-2019"), Code = "ADH5SJH", Description = "Lorem auldfhh"},
                 new Coupon { Id = 2, CouponName = "Body Building", StartTime = DateTime.Parse("01-01-2019"), FinishTime = DateTime.Parse("01-04-2019"), Code = "ADH5SJH", Description = "Lorem auldfhh"},
                 new Coupon { Id = 3, CouponName = "Fitness", StartTime = DateTime.Parse("01-01-2019"), FinishTime = DateTime.Parse("01-04-2019"), Code = "ADH5SJH", Description = "Lorem auldfhh"},
                 new Coupon { Id = 4, CouponName = "Flexibility", StartTime = DateTime.Parse("01-01-2019"), FinishTime = DateTime.Parse("01-04-2019"), Code = "ADH5SJH", Description = "Lorem auldfhh"},
                 new Coupon { Id = 5, CouponName = "Yoga", StartTime = DateTime.Parse("01-01-2019"), FinishTime = DateTime.Parse("01-04-2019"), Code = "ADH5SJH", Description = "Lorem auldfhh"}
                );
            context.DaysOfWeeks.AddOrUpdate(x => x.Id,
                new DaysOfWeek { Id = 1,Name = "Monday" },
                new DaysOfWeek { Id = 2,Name = "Tuesday" },
                new DaysOfWeek { Id = 3,Name = "Wednesday" },
                new DaysOfWeek { Id = 4,Name = "Thursday" },
                new DaysOfWeek { Id = 5,Name = "Friday" },
                new DaysOfWeek { Id = 6,Name = "Saturday" },
                new DaysOfWeek { Id = 7,Name = "Sunday" }

                );


        }
    }
}
