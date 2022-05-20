using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLib.Models {
    public class AppDbContext : DbContext{

        public virtual DbSet<Resources> Resources { get; set; } = null!;


        // constructors
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // sql connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                var connStr = @"server=localhost\sqlexpress;"
                    + "database = ProjectManagementDb;"
                    + "trustServerCertificate = true;"
                    + "trusted_connection = true;";
                optionsBuilder.UseSqlServer(connStr);
            }
        }


    }
}
