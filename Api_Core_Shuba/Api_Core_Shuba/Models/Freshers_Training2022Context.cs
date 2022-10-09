using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Api_Core_Shuba.Models
{
    public partial class Freshers_Training2022Context : DbContext
    {
        public Freshers_Training2022Context()
        {
        }

        public Freshers_Training2022Context(DbContextOptions<Freshers_Training2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ApiCoreShuba> ApiCoreShuba { get; set; }
        public virtual DbSet<PostCoreShuba> PostCoreShuba { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiCoreShuba>(entity =>
            {
                entity.ToTable("Api_Core_Shuba");

                entity.Property(e => e.Domain)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PostCoreShuba>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Post_Cor__AA12601800B420F5");

                entity.ToTable("Post_Core_Shuba");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PostCoreShuba)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Post_Core__Categ__18C26357");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
