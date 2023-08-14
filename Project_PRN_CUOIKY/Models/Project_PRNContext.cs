using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_PRN_CUOIKY.Models
{
    public partial class Project_PRNContext : DbContext
    {
        public Project_PRNContext()
        {
        }

        public Project_PRNContext(DbContextOptions<Project_PRNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Computer> Computers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<RechangeHistory> RechangeHistories { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4E7PE3D\\MSSQLSERVER01;Initial Catalog=Project_PRN;User ID=sa;Password=123;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccName);

                entity.ToTable("Account");

                entity.Property(e => e.AccName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Time).HasColumnName("time");

                entity.HasMany(d => d.Coms)
                    .WithMany(p => p.AccNames)
                    .UsingEntity<Dictionary<string, object>>(
                        "AccCom",
                        l => l.HasOne<Computer>().WithMany().HasForeignKey("ComId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Acc_Com_Computer"),
                        r => r.HasOne<Account>().WithMany().HasForeignKey("AccName").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Acc_Com_Account"),
                        j =>
                        {
                            j.HasKey("AccName", "ComId");

                            j.ToTable("Acc_Com");

                            j.IndexerProperty<string>("AccName").HasMaxLength(50).IsFixedLength();

                            j.IndexerProperty<int>("ComId").HasColumnName("ComID");
                        });
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("Computer");

                entity.Property(e => e.ComId).HasColumnName("ComID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.AccName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.HasOne(d => d.AccNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AccName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Account");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Computer");

                entity.HasOne(d => d.ServiceNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ServiceName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Service");
            });

            modelBuilder.Entity<RechangeHistory>(entity =>
            {
                entity.HasKey(e => e.IdRechange);

                entity.ToTable("Rechange_History");

                entity.Property(e => e.IdRechange)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Rechange");

                entity.Property(e => e.AccName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Monney).HasColumnName("monney");

                entity.HasOne(d => d.AccNameNavigation)
                    .WithMany(p => p.RechangeHistories)
                    .HasForeignKey(d => d.AccName)
                    .HasConstraintName("FK_Rechange_History_Account");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ServiceName);

                entity.ToTable("Service");

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
