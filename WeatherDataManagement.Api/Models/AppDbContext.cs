using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;
using WEManagement.Models;

namespace WeatherDataManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        


        
        public DbSet<Weather> Weather { get; set; }
    }
}
