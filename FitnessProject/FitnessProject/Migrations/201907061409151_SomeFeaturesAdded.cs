namespace FitnessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeFeaturesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaysOfWeeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ClassCalendars", "DaysOfWeekId", c => c.Int(nullable: false));
            AddColumn("dbo.CourseSchedules", "DayOfWeekId", c => c.Int(nullable: false));
            CreateIndex("dbo.ClassCalendars", "DaysOfWeekId");
            CreateIndex("dbo.CourseSchedules", "DayOfWeekId");
            AddForeignKey("dbo.ClassCalendars", "DaysOfWeekId", "dbo.DaysOfWeeks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CourseSchedules", "DayOfWeekId", "dbo.DaysOfWeeks", "Id", cascadeDelete: true);
            DropColumn("dbo.ClassCalendars", "DayOfWeek");
            DropColumn("dbo.CourseSchedules", "DayOfWeek");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseSchedules", "DayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.ClassCalendars", "DayOfWeek", c => c.Int(nullable: false));
            DropForeignKey("dbo.CourseSchedules", "DayOfWeekId", "dbo.DaysOfWeeks");
            DropForeignKey("dbo.ClassCalendars", "DaysOfWeekId", "dbo.DaysOfWeeks");
            DropIndex("dbo.CourseSchedules", new[] { "DayOfWeekId" });
            DropIndex("dbo.ClassCalendars", new[] { "DaysOfWeekId" });
            DropColumn("dbo.CourseSchedules", "DayOfWeekId");
            DropColumn("dbo.ClassCalendars", "DaysOfWeekId");
            DropTable("dbo.DaysOfWeeks");
        }
    }
}
