using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using NHibernate.Criterion;
using System.Security.Permissions;
using Microsoft.Extensions.Logging;

namespace DBContext.Entities
{
    public class DotnetHelpLineContext : DbContext
    { 
        //base parameterless Construtor
        public DotnetHelpLineContext()  
        {
               
        } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information); 
             
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            var cofigsection = configBuilder.GetSection("ConnectionStrings");
            var constring = cofigsection["SqlServerConnetion"] ;
            optionsBuilder.UseSqlServer(constring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        
          public virtual DbSet<Student>? Students { get; set; } 
    }
}
