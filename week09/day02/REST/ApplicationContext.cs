using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
