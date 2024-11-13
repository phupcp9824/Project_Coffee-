using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DuAn1_Coffe.Models
{
    public partial class DB_QuanLy_CaffeeContext : DbContext
    {
        public DB_QuanLy_CaffeeContext()
        {
        }

        public DB_QuanLy_CaffeeContext(DbContextOptions<DB_QuanLy_CaffeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiamGium> GiamGia { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7KKDTTL\\SQLEXPRESS;Database=DB_QuanLy_Caffee;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaGiamGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");

                entity.Property(e => e.GiamGia).HasMaxLength(50);

                entity.Property(e => e.IdGiamGia).HasColumnName("idGiamGia");

                entity.Property(e => e.IdKhachHang).HasColumnName("idKhachHang");

                entity.Property(e => e.IdNhanVien).HasColumnName("idNhanVien");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(20)
                    .HasColumnName("MaHD");

                entity.Property(e => e.NgayMuaHang).HasColumnType("date");

                entity.Property(e => e.NguoiTao).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.IdGiamGiaNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdGiamGia)
                    .HasConstraintName("FK__HoaDon__idGiamGi__534D60F1");

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhachHang)
                    .HasConstraintName("FK__HoaDon__idKhachH__5165187F");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("FK__HoaDon__idNhanVi__52593CB8");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.Ghichu).HasColumnType("text");

                entity.Property(e => e.IdHoaDon).HasColumnName("idHoaDon");

                entity.Property(e => e.IdSanPham).HasColumnName("idSanPham");

                entity.Property(e => e.MaHoaDon).HasMaxLength(10);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK__HoaDonChi__idHoa__571DF1D5");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK__HoaDonChi__idSan__5629CD9C");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.Diachi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .HasColumnName("MaKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(100)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(20)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau).HasMaxLength(255);

                entity.Property(e => e.NgayVaoLam).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(100)
                    .HasColumnName("TenNV");

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.Property(e => e.VaiTro).HasMaxLength(30);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaSP");

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
