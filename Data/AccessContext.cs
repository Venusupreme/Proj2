using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proj2.Models;

namespace Proj2.Data
{
    public class AccessContext : DbContext
    {
        public AccessContext (DbContextOptions<AccessContext> options)
            : base(options)
        {
        }
        
        public DbSet<Maintenance_Requests> maintReqTable{get; set;}
        public DbSet<Users> users{get; set;}
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Faculty>().ToTable("Faculty");
            modelBuilder.Entity<General_Staff>().ToTable("General_Staff");
            modelBuilder.Entity<Check_In_Table>().ToTable("Check_In_Table");
        */
        }
        
        public DbSet<Proj2.Models.Maintenance_Requests> Maint_Req_Table { get; set; } = default!;
    }
}
