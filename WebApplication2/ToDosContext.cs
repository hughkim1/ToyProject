using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToyProject1.Models;

namespace ToyProject1
{
    public class ToDosContext : DbContext
    {
        public ToDosContext(DbContextOptions<ToDosContext> options):base(options)
        {

        }
        public DbSet<ToDo> ToDo { get; set; }
    }
}
