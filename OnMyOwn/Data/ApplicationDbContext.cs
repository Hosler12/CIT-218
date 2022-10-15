using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnMyOwn.Models;

namespace OnMyOwn.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnMyOwn.Models.Customer> Customer { get; set; }
        public DbSet<OnMyOwn.Models.Phone> Phone { get; set; }
    }
}
