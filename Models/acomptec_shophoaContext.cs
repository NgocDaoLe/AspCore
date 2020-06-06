using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace shophoatuoi.Models
{
    public partial class acomptec_shophoaContext : DbContext
    {
        public acomptec_shophoaContext()
        {
        }

        public acomptec_shophoaContext(DbContextOptions<acomptec_shophoaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baiviet> Baiviet { get; set; }
        public virtual DbSet<Chitietchude> Chitietchude { get; set; }
        public virtual DbSet<Chitiethinhthuc> Chitiethinhthuc { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual DbSet<Chitietmausac> Chitietmausac { get; set; }
        public virtual DbSet<Chitiettheloai> Chitiettheloai { get; set; }
        public virtual DbSet<Chucvu> Chucvu { get; set; }
        public virtual DbSet<Chude> Chude { get; set; }
        public virtual DbSet<Hinhanh> Hinhanh { get; set; }
        public virtual DbSet<Hinhthuc> Hinhthuc { get; set; }
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Khachhangdat> Khachhangdat { get; set; }
        public virtual DbSet<Mausac> Mausac { get; set; }
        public virtual DbSet<Nhansu> Nhansu { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<Theloai> Theloai { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=210.245.90.239;Database=acomptec_shophoa;User Id=acomptec_shophoa2017;Password=shophoa@2017");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "acomptec_shophoa2017");

            modelBuilder.Entity<Baiviet>(entity =>
            {
                entity.HasKey(e => e.BvMa)
                    .HasName("PK__BAIVIET__DF577D1FFCABB4B5");

                entity.ToTable("BAIVIET");

                entity.Property(e => e.BvMa)
                    .HasColumnName("BV_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.BvNoidung)
                    .IsRequired()
                    .HasColumnName("BV_NOIDUNG")
                    .HasMaxLength(255);

                entity.Property(e => e.BvTen)
                    .IsRequired()
                    .HasColumnName("BV_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Chitietchude>(entity =>
            {
                entity.HasKey(e => e.CtcdMa)
                    .HasName("PK__CHITIETC__27F39A85B9EAC0AB");

                entity.ToTable("CHITIETCHUDE");

                entity.Property(e => e.CtcdMa)
                    .HasColumnName("CTCD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.CdMa)
                    .IsRequired()
                    .HasColumnName("CD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpMa)
                    .IsRequired()
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.HasOne(d => d.CdMaNavigation)
                    .WithMany(p => p.Chitietchude)
                    .HasForeignKey(d => d.CdMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETCH__CD_MA__71D1E811");

                entity.HasOne(d => d.SpMaNavigation)
                    .WithMany(p => p.Chitietchude)
                    .HasForeignKey(d => d.SpMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETCH__SP_MA__72C60C4A");
            });

            modelBuilder.Entity<Chitiethinhthuc>(entity =>
            {
                entity.HasKey(e => e.CthtMa)
                    .HasName("PK__CHITIETH__647E886CE53B03AA");

                entity.ToTable("CHITIETHINHTHUC");

                entity.Property(e => e.CthtMa)
                    .HasColumnName("CTHT_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.HtMa)
                    .IsRequired()
                    .HasColumnName("HT_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpMa)
                    .IsRequired()
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.HasOne(d => d.HtMaNavigation)
                    .WithMany(p => p.Chitiethinhthuc)
                    .HasForeignKey(d => d.HtMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHI__HT_MA__6A30C649");

                entity.HasOne(d => d.SpMaNavigation)
                    .WithMany(p => p.Chitiethinhthuc)
                    .HasForeignKey(d => d.SpMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHI__SP_MA__6B24EA82");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => e.CthdMa)
                    .HasName("PK__CHITIETH__74F15F58B320FBCC");

                entity.ToTable("CHITIETHOADON");

                entity.Property(e => e.CthdMa)
                    .HasColumnName("CTHD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.CthdPhigiaohang).HasColumnName("CTHD_PHIGIAOHANG");

                entity.Property(e => e.CthdSoluong).HasColumnName("CTHD_SOLUONG");

                entity.Property(e => e.CthdTamtinh).HasColumnName("CTHD_TAMTINH");

                entity.Property(e => e.CthdThanhtien).HasColumnName("CTHD_THANHTIEN");

                entity.Property(e => e.HdMa)
                    .IsRequired()
                    .HasColumnName("HD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.KhMa)
                    .IsRequired()
                    .HasColumnName("KH_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpMa)
                    .IsRequired()
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.HasOne(d => d.HdMaNavigation)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.HdMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHO__HD_MA__5FB337D6");

                entity.HasOne(d => d.KhMaNavigation)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.KhMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHO__KH_MA__60A75C0F");

                entity.HasOne(d => d.SpMaNavigation)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.SpMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHO__SP_MA__5EBF139D");
            });

            modelBuilder.Entity<Chitietmausac>(entity =>
            {
                entity.HasKey(e => e.CtmsMa)
                    .HasName("PK__CHITIETM__42D95EC5AD7EBD69");

                entity.ToTable("CHITIETMAUSAC");

                entity.Property(e => e.CtmsMa)
                    .HasColumnName("CTMS_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.MsMa)
                    .IsRequired()
                    .HasColumnName("MS_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpMa)
                    .IsRequired()
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.HasOne(d => d.MsMaNavigation)
                    .WithMany(p => p.Chitietmausac)
                    .HasForeignKey(d => d.MsMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETMA__MS_MA__6E01572D");

                entity.HasOne(d => d.SpMaNavigation)
                    .WithMany(p => p.Chitietmausac)
                    .HasForeignKey(d => d.SpMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETMA__SP_MA__6EF57B66");
            });

            modelBuilder.Entity<Chitiettheloai>(entity =>
            {
                entity.HasKey(e => e.CttlMa)
                    .HasName("PK__CHITIETT__5E10D6040A03EC55");

                entity.ToTable("CHITIETTHELOAI");

                entity.Property(e => e.CttlMa)
                    .HasColumnName("CTTL_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpMa)
                    .IsRequired()
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.TlMa)
                    .IsRequired()
                    .HasColumnName("TL_MA")
                    .HasMaxLength(4);

                entity.HasOne(d => d.SpMaNavigation)
                    .WithMany(p => p.Chitiettheloai)
                    .HasForeignKey(d => d.SpMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETTH__SP_MA__6754599E");

                entity.HasOne(d => d.TlMaNavigation)
                    .WithMany(p => p.Chitiettheloai)
                    .HasForeignKey(d => d.TlMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETTH__TL_MA__66603565");
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.CvMa)
                    .HasName("PK__CHUCVU__22668DB5DE28D556");

                entity.ToTable("CHUCVU");

                entity.Property(e => e.CvMa)
                    .HasColumnName("CV_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.CvMotacongviec)
                    .IsRequired()
                    .HasColumnName("CV_MOTACONGVIEC")
                    .HasMaxLength(255);

                entity.Property(e => e.CvTen)
                    .IsRequired()
                    .HasColumnName("CV_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Chude>(entity =>
            {
                entity.HasKey(e => e.CdMa)
                    .HasName("PK__CHUDE__3A0922CB6F815B6E");

                entity.ToTable("CHUDE");

                entity.Property(e => e.CdMa)
                    .HasColumnName("CD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.CdTen)
                    .IsRequired()
                    .HasColumnName("CD_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasKey(e => e.HaMa)
                    .HasName("PK__HINHANH__BE83C5BD5F87D992");

                entity.ToTable("HINHANH");

                entity.Property(e => e.HaMa)
                    .HasColumnName("HA_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.HaTen)
                    .IsRequired()
                    .HasColumnName("HA_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.HaUrl)
                    .IsRequired()
                    .HasColumnName("HA_URL")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hinhthuc>(entity =>
            {
                entity.HasKey(e => e.HtMa)
                    .HasName("PK__HINHTHUC__612ADA41DFAFC9A2");

                entity.ToTable("HINHTHUC");

                entity.Property(e => e.HtMa)
                    .HasColumnName("HT_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.HtTen)
                    .IsRequired()
                    .HasColumnName("HT_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.HdMa)
                    .HasName("PK__HOADON__8222DE1FCA19CDC8");

                entity.ToTable("HOADON");

                entity.HasIndex(e => e.HdSdtnguoinhan)
                    .HasName("UQ__HOADON__8875AF4D0CA72833")
                    .IsUnique();

                entity.Property(e => e.HdMa)
                    .HasColumnName("HD_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.HdDiachinguoinhan)
                    .IsRequired()
                    .HasColumnName("HD_DIACHINGUOINHAN")
                    .HasMaxLength(255);

                entity.Property(e => e.HdNgaydat)
                    .HasColumnName("HD_NGAYDAT")
                    .HasColumnType("date");

                entity.Property(e => e.HdNgyagiao)
                    .HasColumnName("HD_NGYAGIAO")
                    .HasColumnType("date");

                entity.Property(e => e.HdSdtnguoinhan)
                    .IsRequired()
                    .HasColumnName("HD_SDTNGUOINHAN")
                    .HasMaxLength(10);

                entity.Property(e => e.HdTennguoinhan)
                    .IsRequired()
                    .HasColumnName("HD_TENNGUOINHAN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Khachhangdat>(entity =>
            {
                entity.HasKey(e => e.KhMa)
                    .HasName("PK__KHACHHAN__2415D8A1AF989479");

                entity.ToTable("KHACHHANGDAT");

                entity.HasIndex(e => e.KhEmail)
                    .HasName("UQ__KHACHHAN__FDD812208FD33DDC")
                    .IsUnique();

                entity.HasIndex(e => e.KhSdt)
                    .HasName("UQ__KHACHHAN__7F10AEEFE728D46E")
                    .IsUnique();

                entity.HasIndex(e => new { e.KhUsername, e.KhPassword })
                    .HasName("DANGNHAPS")
                    .IsUnique();

                entity.Property(e => e.KhMa)
                    .HasColumnName("KH_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.KhDiachi)
                    .IsRequired()
                    .HasColumnName("KH_DIACHI")
                    .HasMaxLength(50);

                entity.Property(e => e.KhEmail)
                    .IsRequired()
                    .HasColumnName("KH_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.KhPassword)
                    .IsRequired()
                    .HasColumnName("KH_PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.KhSdt)
                    .IsRequired()
                    .HasColumnName("KH_SDT")
                    .HasMaxLength(10);

                entity.Property(e => e.KhTen)
                    .IsRequired()
                    .HasColumnName("KH_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.KhUsername)
                    .IsRequired()
                    .HasColumnName("KH_USERNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.MsMa)
                    .HasName("PK__MAUSAC__C65342E40795744E");

                entity.ToTable("MAUSAC");

                entity.Property(e => e.MsMa)
                    .HasColumnName("MS_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.MsTen)
                    .IsRequired()
                    .HasColumnName("MS_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nhansu>(entity =>
            {
                entity.HasKey(e => e.NsMa)
                    .HasName("PK__NHANSU__E800B8E1E8A5194B");

                entity.ToTable("NHANSU");

                entity.HasIndex(e => e.NsCmnd)
                    .HasName("UQ__NHANSU__3BAD2E0FBB0A5E72")
                    .IsUnique();

                entity.HasIndex(e => e.NsSdt)
                    .HasName("UQ__NHANSU__A9760B3654FD3C9F")
                    .IsUnique();

                entity.HasIndex(e => new { e.NsUsername, e.NsPassword })
                    .HasName("DANGNHAP")
                    .IsUnique();

                entity.Property(e => e.NsMa)
                    .HasColumnName("NS_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.CvMa)
                    .IsRequired()
                    .HasColumnName("CV_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.NsCmnd)
                    .IsRequired()
                    .HasColumnName("NS_CMND")
                    .HasMaxLength(12);

                entity.Property(e => e.NsDiachi)
                    .IsRequired()
                    .HasColumnName("NS_DIACHI")
                    .HasMaxLength(100);

                entity.Property(e => e.NsHoten)
                    .IsRequired()
                    .HasColumnName("NS_HOTEN")
                    .HasMaxLength(50);

                entity.Property(e => e.NsNamsinh).HasColumnName("NS_NAMSINH");

                entity.Property(e => e.NsPassword)
                    .IsRequired()
                    .HasColumnName("NS_PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.NsSdt)
                    .IsRequired()
                    .HasColumnName("NS_SDT")
                    .HasMaxLength(10);

                entity.Property(e => e.NsUsername)
                    .IsRequired()
                    .HasColumnName("NS_USERNAME")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CvMaNavigation)
                    .WithMany(p => p.Nhansu)
                    .HasForeignKey(d => d.CvMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NHANSU__CV_MA__3D5E1FD2");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.SpMa)
                    .HasName("PK__SANPHAM__AA2439A34690A334");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.SpMa)
                    .HasColumnName("SP_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.HaMa)
                    .HasColumnName("HA_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.SpGia).HasColumnName("SP_GIA");

                entity.Property(e => e.SpGioithieu)
                    .HasColumnName("SP_GIOITHIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.SpMotachitiet)
                    .IsRequired()
                    .HasColumnName("SP_MOTACHITIET")
                    .HasMaxLength(255);

                entity.Property(e => e.SpTen)
                    .IsRequired()
                    .HasColumnName("SP_TEN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.HaMaNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.HaMa)
                    .HasConstraintName("FK__SANPHAM__HA_MA__03F0984C");
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.HasKey(e => e.TlMa)
                    .HasName("PK__THELOAI__4C7E9EDB8E589126");

                entity.ToTable("THELOAI");

                entity.Property(e => e.TlMa)
                    .HasColumnName("TL_MA")
                    .HasMaxLength(4);

                entity.Property(e => e.TlTen)
                    .IsRequired()
                    .HasColumnName("TL_TEN")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
