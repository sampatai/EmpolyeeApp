using EmployeeApp.Core.Entities.Users;
using EmployeeApp.Core.Interface;
using EmployeeApp.Core.Interface.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DataAccess
{
    public class EmployeeAppDBContext : DbContext
    {
        public EmployeeAppDBContext(DbContextOptions<EmployeeAppDBContext> options)
                            : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        private void OnBeforeSaving()
        {
            IEnumerable<EntityEntry> entries = ChangeTracker.Entries();
            foreach (EntityEntry entry in entries)
            {
                if (entry.Entity is ITrackable trackable)
                {
                    DateTime now = DateTime.Now;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.UpdatedOn = now;
                            break;

                        case EntityState.Added:
                            trackable.CreatedOn = now;
                            trackable.UpdatedOn = now;
                            break;
                    }
                }
            }
        }


    }
}
