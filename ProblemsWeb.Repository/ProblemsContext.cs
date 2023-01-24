using Microsoft.EntityFrameworkCore;
using ProblemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;

namespace ProblemsWeb.Repository
{
    public class ProblemsContext:DbContext
    {
        public ProblemsContext(DbContextOptions<ProblemsContext> options)
        : base(options)
        {
            
        }

     
        public DbSet<KeyWord> KeyWord { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Solution> Solution { get; set; }
        public DbSet<Search> Search { get; set; }
        public DbSet<Like> Like { get; set; }

    }
}
