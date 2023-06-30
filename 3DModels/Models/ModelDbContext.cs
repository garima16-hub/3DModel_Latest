using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using _3DModels.Models;

namespace _3DModels.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
        {
        }

        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Style> FrameStyleTeacups { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Attachments> Attachment { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LIN24010016\\SQLEXPRESS;Initial Catalog=3DModels;Integrated Security=True;");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Style>(entity =>
            {
                entity.HasKey(e => e.StyleId)
                    .HasName("PK__FrameSty__D333B397923E1D5A");

                entity.ToTable("FrameStyleTeacup");

                entity.Property(e => e.StyleId)
                    .ValueGeneratedNever()
                    .HasColumnName("style_id");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Material)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("material");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_name");

                entity.Property(e => e.TeacupId).HasColumnName("teacup_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderId");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerName");
                entity.Property(e => e.ProductId).HasColumnName("ProductId");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OrderDate");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderStatus");

                entity.Property(e => e.Price).HasColumnName("Price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductName");

                entity.Property(e => e.Quantity).HasColumnName("Quantity");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TotalAmount");
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.ToTable("Attachments");

                entity.Property(e => e.product_id)
                    .ValueGeneratedNever()
                    .HasColumnName("product_id ");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Price");

                entity.Property(e => e.Filepath)
               .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsRequired()
                    .HasColumnName("Filepath");
                


                entity.Property(e => e.Accessories)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Accessories");

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserEmail");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserPassword");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ModelId)
                    .ValueGeneratedNever()
                    .HasColumnName("ModelId");


                entity.Property(e => e.ModelName)
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .HasColumnName("ModelName");


                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Description");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}


