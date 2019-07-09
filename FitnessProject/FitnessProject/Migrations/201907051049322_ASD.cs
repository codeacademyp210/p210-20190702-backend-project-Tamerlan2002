namespace FitnessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassCalendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DayOfWeek = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        Descrption = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                        Price = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CouponName = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayOfWeek = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        CourseID_Id = c.Int(),
                        RoomId_Id = c.Int(),
                        TrainerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID_Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId_Id)
                .ForeignKey("dbo.Trainers", t => t.TrainerId_Id)
                .Index(t => t.CourseID_Id)
                .Index(t => t.RoomId_Id)
                .Index(t => t.TrainerId_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Infoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Adress = c.String(),
                        City = c.String(),
                        Pincode = c.String(),
                        Fax = c.String(),
                        Website = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackageName = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        GenderOfUser = c.Int(nullable: false),
                        DateOfBirith = c.DateTime(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Adress = c.String(),
                        StatusOfUser = c.Int(nullable: false),
                        MoneyPaid = c.Double(nullable: false),
                        RegisterTime = c.DateTime(nullable: false),
                        CourseId_Id = c.Int(),
                        TrainerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId_Id)
                .ForeignKey("dbo.Trainers", t => t.TrainerId_Id)
                .Index(t => t.CourseId_Id)
                .Index(t => t.TrainerId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "TrainerId_Id", "dbo.Trainers");
            DropForeignKey("dbo.Users", "CourseId_Id", "dbo.Courses");
            DropForeignKey("dbo.CourseSchedules", "TrainerId_Id", "dbo.Trainers");
            DropForeignKey("dbo.CourseSchedules", "RoomId_Id", "dbo.Rooms");
            DropForeignKey("dbo.CourseSchedules", "CourseID_Id", "dbo.Courses");
            DropForeignKey("dbo.ClassCalendars", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Users", new[] { "TrainerId_Id" });
            DropIndex("dbo.Users", new[] { "CourseId_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "TrainerId_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "RoomId_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "CourseID_Id" });
            DropIndex("dbo.ClassCalendars", new[] { "Course_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Packages");
            DropTable("dbo.Infoes");
            DropTable("dbo.Trainers");
            DropTable("dbo.Rooms");
            DropTable("dbo.CourseSchedules");
            DropTable("dbo.Coupons");
            DropTable("dbo.Courses");
            DropTable("dbo.ClassCalendars");
        }
    }
}
