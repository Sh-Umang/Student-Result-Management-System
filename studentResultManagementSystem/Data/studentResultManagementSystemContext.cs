using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentResultManagementSystem.Models;

namespace studentResultManagementSystem.Data
{
    public class studentResultManagementSystemContext : DbContext
    {
        public studentResultManagementSystemContext (DbContextOptions<studentResultManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentResultManagementSystem.Models.Subject> Subject { get; set; } = default!;

        public DbSet<StudentResultManagementSystem.Models.Student> Student { get; set; } = default!;
        public DbSet<Result> Results { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Result>().HasKey(nameof(Result.std_id), nameof(Result.sub_id));
        }
    }
}
