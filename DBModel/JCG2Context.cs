using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace jcg2_dotnet.DBModel
{
    public partial class JCG2Context : DbContext
    {
        public JCG2Context()
        {
        }

        public JCG2Context(DbContextOptions<JCG2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BigSmOdd> BigSmOdds { get; set; }
        public virtual DbSet<CROdd> Crodds { get; set; }
        public virtual DbSet<EOOdd> Eoodds { get; set; }
        public virtual DbSet<Ftsodd> Ftsodds { get; set; }
        public virtual DbSet<HadiHadodd> HadiHadodds { get; set; }
        public virtual DbSet<HadiOdd> HadiOdds { get; set; }
        public virtual DbSet<Hadodd> Hadodds { get; set; }
        public virtual DbSet<Hfodd> Hfodds { get; set; }
        public virtual DbSet<Match> Matches { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Database=JCG2;User Id=admin;Password=xsnbsle9;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<BigSmOdd>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BigOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.Median).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SmallOdds).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<CROdd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CROdds");

                entity.Property(e => e.Ao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AO");

                entity.Property(e => e.Do)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("DO");

                entity.Property(e => e.H0a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A0");

                entity.Property(e => e.H0a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A1");

                entity.Property(e => e.H0a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A2");

                entity.Property(e => e.H0a3)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A3");

                entity.Property(e => e.H0a4)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A4");

                entity.Property(e => e.H0a5)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H0A5");

                entity.Property(e => e.H1a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A0");

                entity.Property(e => e.H1a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A1");

                entity.Property(e => e.H1a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A2");

                entity.Property(e => e.H1a3)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A3");

                entity.Property(e => e.H1a4)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A4");

                entity.Property(e => e.H1a5)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H1A5");

                entity.Property(e => e.H2a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A0");

                entity.Property(e => e.H2a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A1");

                entity.Property(e => e.H2a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A2");

                entity.Property(e => e.H2a3)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A3");

                entity.Property(e => e.H2a4)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A4");

                entity.Property(e => e.H2a5)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H2A5");

                entity.Property(e => e.H3a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H3A0");

                entity.Property(e => e.H3a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H3A1");

                entity.Property(e => e.H3a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H3A2");

                entity.Property(e => e.H3a3)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H3A3");

                entity.Property(e => e.H4a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H4A0");

                entity.Property(e => e.H4a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H4A1");

                entity.Property(e => e.H4a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H4A2");

                entity.Property(e => e.H5a0)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H5A0");

                entity.Property(e => e.H5a1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H5A1");

                entity.Property(e => e.H5a2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("H5A2");

                entity.Property(e => e.Ho)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HO");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<EOOdd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EOOdds");

                entity.Property(e => e.Even).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.Odd).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<Ftsodd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FTSOdds");

                entity.Property(e => e.AwayOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DrawOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HomeOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<HadiHadodd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HadiHADOdds");

                entity.Property(e => e.AwayOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DrawOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HomeOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<HadiOdd>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AwayHadicap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AwayOdds).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.HomeHadicap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomeOdds).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<Hadodd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HADOdds");

                entity.Property(e => e.AwayOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DrawOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HomeOdds).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<Hfodd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HFOdds");

                entity.Property(e => e.Aa)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AA");

                entity.Property(e => e.Ad)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AD");

                entity.Property(e => e.Ah)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH");

                entity.Property(e => e.Da)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("DA");

                entity.Property(e => e.Dd)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("DD");

                entity.Property(e => e.Dh)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("DH");

                entity.Property(e => e.Ha)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HA");

                entity.Property(e => e.Hd)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HD");

                entity.Property(e => e.Hh)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HH");

                entity.Property(e => e.MatchRid).HasColumnName("MatchRID");

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AwayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChawayName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CHAwayName");

                entity.Property(e => e.ChhomeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CHHomeName");

                entity.Property(e => e.HomeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowId).HasColumnName("RowID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
