using E_TicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E_TicaretSitesi.Data
{
    public class ApplicationDbContext : DbContext
    {
        
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
            public DbSet<Products> Products { get; set; }
            public DbSet<Users> Users { get; set; }


    }
}
