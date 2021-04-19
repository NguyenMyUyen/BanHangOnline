using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BHDT.Model
{
    public partial class BHDTDbContext : DbContext
    {
        public BHDTDbContext()
            : base("name=BHDTDbContext")
        {
        }

        public virtual DbSet<BinhLuan> BinhLuans { get; set; }
        public virtual DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhViens { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonDatHang>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DonDatHang>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithOptional(e => e.DonDatHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DonDatHangs)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.LoaiSanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LoaiThanhVien>()
                .HasMany(e => e.ThanhViens)
                .WithOptional(e => e.LoaiThanhVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhaps)
                .WithOptional(e => e.NhaCungCap)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.NhaCungCap)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaSanXuat>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.NhaSanXuat)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.BinhLuans)
                .WithOptional(e => e.SanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithOptional(e => e.SanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.BinhLuans)
                .WithOptional(e => e.ThanhVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.KhachHangs)
                .WithOptional(e => e.ThanhVien)
                .WillCascadeOnDelete();
        }
    }
}
