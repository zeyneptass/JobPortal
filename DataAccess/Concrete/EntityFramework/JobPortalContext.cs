using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class JobPortalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ZEYNEP\SQLEXPRESS01;Database=DBJobPortal;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobListing> JobListings { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationStatus>().HasKey(a => a.StatusId);
            base.OnModelCreating(modelBuilder);
        }

    }
}
