using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace crud.Models
{
    public partial class crudContext : DbContext
    {
        public crudContext()
        {
        }

        public crudContext(DbContextOptions<crudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(64)");
            });
        }
    }
}
