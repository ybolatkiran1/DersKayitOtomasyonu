using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-RCDV2UP\\SQLEXPRESS;database=UskudarBelediyeKayıtDB;" +
                "integrated security=true;;TrustServerCertificate=true;");
        }
       
       public DbSet<STUDENT> STUDENTS { get; set; }
       
       
        

    }
}
