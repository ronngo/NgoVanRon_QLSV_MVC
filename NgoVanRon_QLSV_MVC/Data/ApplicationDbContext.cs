using Microsoft.EntityFrameworkCore;
using NgoVanRon_QLSV_MVC.Models;
using System.Collections.Generic;

namespace NgoVanRon_QLSV_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<NgoVanRon_Lop> ngovanron_lop { get; set; }
        public DbSet<NgoVanRon_Sinhvien> ngovanron_sinhvien { get; set; }
    }
}
