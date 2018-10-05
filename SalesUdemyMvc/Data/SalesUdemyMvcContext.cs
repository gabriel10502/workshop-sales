using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesUdemyMvc.Models
{
    public class SalesUdemyMvcContext : DbContext
    {
        public SalesUdemyMvcContext (DbContextOptions<SalesUdemyMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesUdemyMvc.Models.Department> Department { get; set; }
    }
}
