using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace books.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base (options)
        {


        }

        public DbSet<Employee> employee { get; set; }
    }
}
