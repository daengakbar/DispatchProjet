namespace AceAdmin.Web.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AceAdmin.Web.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<AceAdmin.Web.DAL.DBConection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AceAdmin.Web.DAL.DBConection context)
        {
            //public DbSet<WorkerModel> Workers { get; set; }
            //public DbSet<VehicleModel> Vehicles { get; set; }
            //public DbSet<JobsModel> Jobs { get; set; }

            var workers = new List<WorkerModel>
            {
                new WorkerModel { nWorkID = 1,   cWorkName = "Akbar",
                                  cICnumber = "DD0123", cPhoneNum="082190763270", nSalary=10000 },
            };
            workers.ForEach(s => context.Workers.AddOrUpdate(p => p.cWorkName, s));
           // context.SaveChanges();

            var Vehicles = new List<VehicleModel>
            {
                new VehicleModel  { nVehiID = 1,  cLicensePNum = "B2340WNE",  cType  = "TRUCK",
                                    cStaAdd = "Jl.Wr Supratman No.60",cEndAdd = "Jl. Gading Raya No.110" } ,
            };
            Vehicles.ForEach(s => context.Vehicles.AddOrUpdate(p => p.cLicensePNum, s));
            //context.SaveChanges();

            var Jobs = new List<JobsModel>
            {
                new JobsModel  { nJobID = 1,   clocation = "Tangerang",  cDuration  = 10,
                                 dStartDate = DateTime.Parse("2017-09-01"),  dEndDate = DateTime.Parse("2017-20-01") } ,
            };
            Jobs.ForEach(s => context.Jobs.AddOrUpdate(p => p.cJobNum, s));
           // context.SaveChanges();
           
        }
    }
}
