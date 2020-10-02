using ABCPharmacy.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ABCPharmacy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {
           
        }
        public DbSet<Medicine> Medicines { get; set; }
    }
}
