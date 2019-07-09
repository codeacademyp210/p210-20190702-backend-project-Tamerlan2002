namespace FitnessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASD1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseSchedules", "CourseID_Id", "dbo.Courses");
            DropForeignKey("dbo.CourseSchedules", "RoomId_Id", "dbo.Rooms");
            DropForeignKey("dbo.CourseSchedules", "TrainerId_Id", "dbo.Trainers");
            DropIndex("dbo.CourseSchedules", new[] { "CourseID_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "RoomId_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "TrainerId_Id" });
            RenameColumn(table: "dbo.CourseSchedules", name: "CourseID_Id", newName: "CourseId");
            RenameColumn(table: "dbo.CourseSchedules", name: "RoomId_Id", newName: "RoomId");
            RenameColumn(table: "dbo.CourseSchedules", name: "TrainerId_Id", newName: "TrainerId");
            AlterColumn("dbo.CourseSchedules", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseSchedules", "RoomId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseSchedules", "TrainerId", c => c.Int(nullable: false));
            CreateIndex("dbo.CourseSchedules", "RoomId");
            CreateIndex("dbo.CourseSchedules", "TrainerId");
            CreateIndex("dbo.CourseSchedules", "CourseId");
            AddForeignKey("dbo.CourseSchedules", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CourseSchedules", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CourseSchedules", "TrainerId", "dbo.Trainers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseSchedules", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.CourseSchedules", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.CourseSchedules", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseSchedules", new[] { "CourseId" });
            DropIndex("dbo.CourseSchedules", new[] { "TrainerId" });
            DropIndex("dbo.CourseSchedules", new[] { "RoomId" });
            AlterColumn("dbo.CourseSchedules", "TrainerId", c => c.Int());
            AlterColumn("dbo.CourseSchedules", "RoomId", c => c.Int());
            AlterColumn("dbo.CourseSchedules", "CourseId", c => c.Int());
            RenameColumn(table: "dbo.CourseSchedules", name: "TrainerId", newName: "TrainerId_Id");
            RenameColumn(table: "dbo.CourseSchedules", name: "RoomId", newName: "RoomId_Id");
            RenameColumn(table: "dbo.CourseSchedules", name: "CourseId", newName: "CourseID_Id");
            CreateIndex("dbo.CourseSchedules", "TrainerId_Id");
            CreateIndex("dbo.CourseSchedules", "RoomId_Id");
            CreateIndex("dbo.CourseSchedules", "CourseID_Id");
            AddForeignKey("dbo.CourseSchedules", "TrainerId_Id", "dbo.Trainers", "Id");
            AddForeignKey("dbo.CourseSchedules", "RoomId_Id", "dbo.Rooms", "Id");
            AddForeignKey("dbo.CourseSchedules", "CourseID_Id", "dbo.Courses", "Id");
        }
    }
}
