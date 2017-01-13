namespace AceAdmin.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobsModel",
                c => new
                    {
                        nJobID = c.Int(nullable: false, identity: true),
                        cJobNum = c.String(),
                        clocation = c.String(),
                        cDuration = c.Int(nullable: false),
                        dStartDate = c.DateTime(nullable: false),
                        dEndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.nJobID);
            
            CreateTable(
                "dbo.VehicleModel",
                c => new
                    {
                        nVehiID = c.Int(nullable: false, identity: true),
                        cLicensePNum = c.String(),
                        cType = c.String(),
                        cStaAdd = c.String(),
                        cEndAdd = c.String(),
                    })
                .PrimaryKey(t => t.nVehiID);
            
            CreateTable(
                "dbo.WorkerModel",
                c => new
                    {
                        nWorkID = c.Int(nullable: false, identity: true),
                        cWorkName = c.String(),
                        cICnumber = c.String(),
                        cPhoneNum = c.String(),
                        nSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.nWorkID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkerModel");
            DropTable("dbo.VehicleModel");
            DropTable("dbo.JobsModel");
        }
    }
}
