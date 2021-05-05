using Microsoft.EntityFrameworkCore;
using removie.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace removie.Core.Context
{
    public class RemovieDbContext : DbContext
    {
        public RemovieDbContext(DbContextOptions<RemovieDbContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rate> Rates { get; set; }
    }
}
