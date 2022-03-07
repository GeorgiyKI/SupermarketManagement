using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Identity.Data;

namespace WebApp.Data
{
    public class AccountContext : IdentityDbContext<AppUser>
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(250);

            builder.Entity<AppUser>()
                .Property(e => e.LastName)
                .HasMaxLength(250);
        }
    }
}
