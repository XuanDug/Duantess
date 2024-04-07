using System;
using System.Collections.Generic;
using DAL.Models.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bangluong> Bangluongs { get; set; }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giaoca> Giaocas { get; set; }

    public virtual DbSet<Giaocanhanvien> Giaocanhanviens { get; set; }

    public virtual DbSet<Giay> Giays { get; set; }

    public virtual DbSet<Giaychitiet> Giaychitiets { get; set; }

    public virtual DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Kieudang> Kieudangs { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Uudai> Uudais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-02LDR80N\\SQLEXPRESS ;Initial Catalog= DBGIAY_DUAN1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangluong>(entity =>
        {
            entity.HasKey(e => e.Maluong).HasName("PK__BANGLUON__D9BA4D00E848E264");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Bangluongs).HasConstraintName("FK__BANGLUONG__MATAI__68487DD7");
        });

        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F879CF71EB");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Chatlieus).HasConstraintName("FK__CHATLIEU__MATAIK__693CA210");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6AED0875A6");
        });

        modelBuilder.Entity<Giaoca>(entity =>
        {
            entity.HasKey(e => e.Magiaoca).HasName("PK__GIAOCA__7D3545CCD6CC5659");
        });

        modelBuilder.Entity<Giaocanhanvien>(entity =>
        {
            entity.HasKey(e => e.Magiaocanhanvien).HasName("PK__GIAOCANH__B0F1BCFD3301E370");

            entity.HasOne(d => d.MagiaocaNavigation).WithMany(p => p.Giaocanhanviens).HasConstraintName("FK__GIAOCANHA__MAGIA__6A30C649");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Giaocanhanviens).HasConstraintName("FK__GIAOCANHA__MATAI__6B24EA82");
        });

        modelBuilder.Entity<Giay>(entity =>
        {
            entity.HasKey(e => e.Magiay).HasName("PK__GIAY__0C880C5881E718A2");
        });

        modelBuilder.Entity<Giaychitiet>(entity =>
        {
            entity.HasKey(e => e.Magiaychitiet).HasName("PK__GIAYCHIT__196AD703DA5EE81B");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MACHA__6C190EBB");

            entity.HasOne(d => d.MagiayNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAGIA__6D0D32F4");

            entity.HasOne(d => d.MakichcoNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAKIC__6E01572D");

            entity.HasOne(d => d.MakieudangNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAKIE__6EF57B66");

            entity.HasOne(d => d.MamausacNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MAMAU__6FE99F9F");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Giaychitiets).HasConstraintName("FK__GIAYCHITI__MATHU__70DDC3D8");

            entity.HasOne(d => d.NguoisuaNavigation).WithMany(p => p.GiaychitietNguoisuaNavigations).HasConstraintName("FK__GIAYCHITI__NGUOI__72C60C4A");

            entity.HasOne(d => d.NguoitaoNavigation).WithMany(p => p.GiaychitietNguoitaoNavigations).HasConstraintName("FK__GIAYCHITI__NGUOI__71D1E811");
        });

        modelBuilder.Entity<Hinhthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mahinhthucthanhtoan).HasName("PK__HINHTHUC__C3B2561F9C789ACA");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF511904DFF");

            entity.HasOne(d => d.MahinhthucthanhtoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAHINHTH__73BA3083");

            entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAKHACHH__74AE54BC");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MATAIKHO__75A278F5");

            entity.HasOne(d => d.MauudaiNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAUUDAI__76969D2E");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.Mahoadonchitiet).HasName("PK__HOADONCH__EF957FF02099CF74");

            entity.HasOne(d => d.MagiaychitietNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHI__MAGIA__778AC167");

            entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHI__MAHOA__787EE5A0");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2F9AF0B12F");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makichco).HasName("PK__KICHCO__7EDFFF291BA51766");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kichcos).HasConstraintName("FK__KICHCO__MATAIKHO__797309D9");
        });

        modelBuilder.Entity<Kieudang>(entity =>
        {
            entity.HasKey(e => e.Makieudang).HasName("PK__KIEUDANG__877F27F25237F1B7");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kieudangs).HasConstraintName("FK__KIEUDANG__MATAIK__7A672E12");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamausac).HasName("PK__MAUSAC__99E7A68FCCC83F3C");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Mausacs).HasConstraintName("FK__MAUSAC__MATAIKHO__7B5B524B");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Mataikhoan).HasName("PK__TAIKHOAN__2ED8B5177930EB9D");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Taikhoans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__MACHUC__7C4F7684");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F638736C7B5A");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Thuonghieus).HasConstraintName("FK__THUONGHIE__MATAI__7D439ABD");
        });

        modelBuilder.Entity<Uudai>(entity =>
        {
            entity.HasKey(e => e.Mauudai).HasName("PK__UUDAI__3F58B4FD121EB203");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Uudais).HasConstraintName("FK__UUDAI__MATAIKHOA__7E37BEF6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
