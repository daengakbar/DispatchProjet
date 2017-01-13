namespace AceAdmin.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.JobsModel", "nVehiID");
            AddForeignKey("dbo.JobsModel", "nVehiID", "dbo.VehicleModel", "nVehiID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobsModel", "nVehiID", "dbo.VehicleModel");
            DropIndex("dbo.JobsModel", new[] { "nVehiID" });
        }
    }
}
