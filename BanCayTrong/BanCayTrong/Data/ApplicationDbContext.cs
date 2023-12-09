using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BanCayTrong.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanCayTrong.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CthoaDon> CthoaDon { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7KLGFAA;Database=BanCayTrong;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CthoaDon>(entity =>
            {
                entity.HasKey(e => e.Macthd)
                    .HasName("PK__CTHoaDon__50C3A3F8F9E89068");

                entity.Property(e => e.Dongia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtien).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.CthoaDon)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHoaDon__mahd__59FA5E80");

                entity.HasOne(d => d.MamhNavigation)
                    .WithMany(p => p.CthoaDon)
                    .HasForeignKey(d => d.Mamh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHoaDon__mamh__5AEE82B9");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.Madm)
                    .HasName("PK__DanhMuc__7A21E0201A49B712");
            });

            modelBuilder.Entity<DiaChi>(entity =>
            {
                entity.HasKey(e => e.Madc)
                    .HasName("PK__DiaChi__7A21E05A430072BC");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.DiaChi)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DiaChi__makh__5070F446");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.Mahd)
                    .HasName("PK__HoaDon__7A2100DE6503D3B3");

                entity.Property(e => e.Tongtien).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MadcNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.Madc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__madc__571DF1D5");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__makh__5629CD9C");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .HasName("PK__KhachHan__7A21BB4C5ECE21C3");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Matkhau).IsUnicode(false);
            });

            modelBuilder.Entity<MatHang>(entity =>
            {
                entity.HasKey(e => e.Mamh)
                    .HasName("PK__MatHang__7A21CB8EB57FA38A");

                entity.Property(e => e.Hinhanh).IsUnicode(false);

                entity.HasOne(d => d.MadmNavigation)
                    .WithMany(p => p.MatHang)
                    .HasForeignKey(d => d.Madm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MatHang__madm__4BAC3F29");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NhanVien__7A21B37D676B2C66");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Matkhau).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
