//Worker, Vehicle, Job
using AceAdmin.Web.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AceAdmin.Web.DAL
{
    public class DBConection : DbContext 
    {
        public DbSet<WorkerModel> Workers { get; set; }
        public DbSet<VehicleModel> Vehicles { get; set; }
        public DbSet<JobsModel> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}



