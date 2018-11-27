using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Project1.Data
{
  public class DbContext : IdentityDbContext<User>
  {
        public DbContext(DbContextOptions<AngularAppContext> options)
            : base(options)
        {
        }

        public DbSet<Project1.Models.Account> Accounts { get; set; }
    }

    
}
