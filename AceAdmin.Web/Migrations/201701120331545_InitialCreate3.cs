namespace AceAdmin.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobsModel", "nWorkID", c => c.Int(nullable: false));
            AddColumn("dbo.JobsModel", "nVehiID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobsModel", "nVehiID");
            DropColumn("dbo.JobsModel", "nWorkID");
        }
    }
}
