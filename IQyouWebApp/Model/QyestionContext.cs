using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQyouWebApp.Model
{
    public class IQyouDbContext : DbContext

    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Questionneer> Questionneers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Questionneers.db");
        }

    }
}
