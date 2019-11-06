using DatabaseIntegration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseIntegration
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
