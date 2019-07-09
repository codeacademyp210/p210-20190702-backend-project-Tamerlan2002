namespace FitnessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChangesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Packages", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Packages", "Amount");
        }
    }
}
