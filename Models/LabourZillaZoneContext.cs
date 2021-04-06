using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LabourZillaProjectAPI.Models
{
    public partial class LabourZillaZoneContext : DbContext
    {
        public LabourZillaZoneContext()
        {
        }

        public LabourZillaZoneContext(DbContextOptions<LabourZillaZoneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Labour> Labour { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:labourzilla123.database.windows.net,1433;Initial Catalog=LabourZillaZone;Persist Security Info=False;User ID=LabourZilla123;Password=Pragya@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__Admin__4DDA2818EA939EE7");

                entity.Property(e => e.LoginId).HasMaxLength(50);

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Apassword)
                    .IsRequired()
                    .HasColumnName("APassword")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleA)
                    .IsRequired()
                    .HasColumnName("Role_A")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Labour>(entity =>
            {
                entity.ToTable("labour");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Available).HasMaxLength(20);

                entity.Property(e => e.CityAddress).HasMaxLength(100);

                entity.Property(e => e.Cnfrmpswd).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcontact)
                    .IsRequired()
                    .HasColumnName("LContact")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ppic)
                    .HasColumnName("PPic")
                    .HasMaxLength(100);

                entity.Property(e => e.Profession).HasMaxLength(50);

                entity.Property(e => e.Pswd)
                    .HasColumnName("pswd")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleL)
                    .IsRequired()
                    .HasColumnName("Role_L")
                    .HasMaxLength(50);

                entity.Property(e => e.StateL).HasMaxLength(50);

                entity.Property(e => e.TimeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasColumnName("TName")
                    .HasMaxLength(50);

                entity.Property(e => e.TprojectName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C8CC555E4");

                entity.Property(e => e.UserId).HasMaxLength(100);

                entity.Property(e => e.CityAddress).HasMaxLength(100);

                entity.Property(e => e.ConfirmPassword)
                    .HasColumnName("Confirm_password")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcontact)
                    .IsRequired()
                    .HasColumnName("LContact")
                    .HasMaxLength(10);

                entity.Property(e => e.PasswordC).HasMaxLength(100);

                entity.Property(e => e.RoleU)
                    .IsRequired()
                    .HasColumnName("Role_U")
                    .HasMaxLength(50);

                entity.Property(e => e.StateC).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
