using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class HaliciogluContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = HaliciogluLawOffice; Trusted_Connection = true");
        }
        public DbSet<Announcement>? Announcements { get; set; }
        public DbSet<Attorney>? Attorney { get; set; }
        public DbSet<AttorneyImage>? AttorneyImages { get; set; }
        public DbSet<OfficeLocations>? OfficeLocations { get; set; }
        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }
    }
}
