using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASMLibrary.DataAccess
{
    public partial class ASMFContext : DbContext
    {
        public ASMFContext()
        {
        }

        public ASMFContext(DbContextOptions<ASMFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<Loai> Loais { get; set; } = null!;
        public virtual DbSet<MonAn> MonAns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3NQBKB;Database=ASMF;uid=sa;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => e.Idctdh)
                    .HasName("PK__ChiTietD__0F87803DF7E2C2A9");

                entity.ToTable("ChiTietDonHang");

                entity.Property(e => e.Idctdh)
                    .HasMaxLength(5)
                    .HasColumnName("IDCTDH");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.IddonHang)
                    .HasMaxLength(5)
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.Idmon)
                    .HasMaxLength(5)
                    .HasColumnName("IDMon");

                entity.Property(e => e.Tt).HasColumnName("TT");

                entity.HasOne(d => d.IddonHangNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.IddonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_DonHang");

                entity.HasOne(d => d.IdmonNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.Idmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_MonAn");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.Idcomment)
                    .HasName("PK__Comment__6E1BFE941C511DE8");

                entity.ToTable("Comment");

                entity.Property(e => e.Idcomment)
                    .HasMaxLength(5)
                    .HasColumnName("IDcomment");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(500)
                    .HasColumnName("Comment");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(5)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Idmon)
                    .HasMaxLength(5)
                    .HasColumnName("IDMon");

                entity.Property(e => e.Tt).HasColumnName("TT");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Idkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_KhachHang");

                entity.HasOne(d => d.IdmonNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Idmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_MonAn");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.IddonHang)
                    .HasName("PK__DonHang__9CA232F781188B15");

                entity.ToTable("DonHang");

                entity.Property(e => e.IddonHang)
                    .HasMaxLength(5)
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.Diachi).HasMaxLength(300);

                entity.Property(e => e.Idkh)
                    .HasMaxLength(5)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(13)
                    .HasColumnName("SDT");

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.Tt).HasColumnName("TT");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK_DonHang_KhachHang");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.IdgioHang)
                    .HasName("PK__GioHang__0B2CDDAEE6C6B42E");

                entity.ToTable("GioHang");

                entity.Property(e => e.IdgioHang)
                    .HasMaxLength(5)
                    .HasColumnName("IDGioHang");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(5)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Idmon)
                    .HasMaxLength(5)
                    .HasColumnName("IDMon");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK_GioHang_KhachHang");

                entity.HasOne(d => d.IdmonNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.Idmon)
                    .HasConstraintName("FK_GioHang_MonAn");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Idkh)
                    .HasName("PK__KhachHan__B87DC1A7573F772D");

                entity.ToTable("KhachHang");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(5)
                    .HasColumnName("IDKH");

                entity.Property(e => e.DiachiKh)
                    .HasMaxLength(300)
                    .HasColumnName("DiachiKH");

                entity.Property(e => e.HotenKh)
                    .HasMaxLength(50)
                    .HasColumnName("HotenKH");

                entity.Property(e => e.MailKh)
                    .HasMaxLength(50)
                    .HasColumnName("MailKH");

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Sdtkh)
                    .HasMaxLength(13)
                    .HasColumnName("SDTKH");

                entity.Property(e => e.Tt).HasColumnName("TT");

                entity.Property(e => e.Role)
                   .HasMaxLength(50)
                   .HasColumnName("Role");

                entity.Property(e => e.Username).HasMaxLength(30);
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.Idloai)
                    .HasName("PK__Loai__CA55DD6705E25973");

                entity.ToTable("Loai");

                entity.Property(e => e.Idloai)
                    .HasMaxLength(5)
                    .HasColumnName("IDLoai");

                entity.Property(e => e.TenLoai).HasMaxLength(30);
            });

            modelBuilder.Entity<MonAn>(entity =>
            {
                entity.HasKey(e => e.Idmon)
                    .HasName("PK__MonAn__941E276A276D7086");

                entity.ToTable("MonAn");

                entity.Property(e => e.Idmon)
                    .HasMaxLength(5)
                    .HasColumnName("IDMon");

                entity.Property(e => e.ChuThich).HasMaxLength(300);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.Hinh).HasColumnType("text");

                entity.Property(e => e.Idloai)
                    .HasMaxLength(5)
                    .HasColumnName("IDLoai");

                entity.Property(e => e.TenMon).HasMaxLength(50);

                entity.Property(e => e.Tt).HasColumnName("TT");

                entity.HasOne(d => d.IdloaiNavigation)
                    .WithMany(p => p.MonAns)
                    .HasForeignKey(d => d.Idloai)
                    .HasConstraintName("FK_MonAn_Loai");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
