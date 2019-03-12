using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtPiece>().HasMany<ArtData>(d => d.Data);
        }
        public DbSet<ArtPiece> ArtPieces { get; set; }
        public DbSet<ArtData> ArtDatas { get; set; }
    }
}
