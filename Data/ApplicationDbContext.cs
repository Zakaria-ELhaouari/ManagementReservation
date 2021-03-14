using ManagementReservation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementReservation.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<String>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<String>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<String>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<String>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<String>>().ToTable("UserTokens");
        }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Typereservation> TypeReservation { get; set; }
    }
}
