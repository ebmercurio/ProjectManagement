using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectManagementLib.Models {
    public class AppDbContext : DbContext {


        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;"
                            + "database=ProjectManagementDb;"
                            + "trustServerCertificate=true;"
                            + "trusted_connection=true;";
            builder.UseSqlServer(connStr);

        }
    }
}
