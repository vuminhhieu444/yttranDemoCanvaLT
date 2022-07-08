using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Yttran.Models
{
    public partial class YttranContext : DbContext
    {
        public YttranContext()
        {
        }

        public YttranContext(DbContextOptions<YttranContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ServiceDetail> ServiceDetails { get; set; }
        public virtual DbSet<SlideLogo> SlideLogos { get; set; }
        public virtual DbSet<SubMenu> SubMenus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Yttran;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");

                entity.Property(e => e.UsrerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usrer_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .HasColumnName("address")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .HasColumnName("phonenumber")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllContent).HasColumnName("all_content");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<ServiceDetail>(entity =>
            {
                entity.ToTable("ServiceDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.MenuId).HasColumnName("menuId");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.ServiceDetails)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ServiceDetail_menu");
            });

            modelBuilder.Entity<SlideLogo>(entity =>
            {
                entity.ToTable("slide_logo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(150)
                    .HasColumnName("logo_path");

                entity.Property(e => e.SlidePath)
                    .HasMaxLength(150)
                    .HasColumnName("slide_path");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<SubMenu>(entity =>
            {
                entity.ToTable("sub_menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.SubMenus)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_sub_menu_menu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
