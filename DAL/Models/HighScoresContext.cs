using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HighScoresContext : DbContext
{
    public HighScoresContext()
    {
    }

    public HighScoresContext(DbContextOptions<HighScoresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<HighScore> HighScores { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database=GameHighScores; Trusted_Connection=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.Property(e => e.Name).IsFixedLength();
        });

        modelBuilder.Entity<HighScore>(entity =>
        {
            entity.HasKey(e => new { e.GameId, e.PlayerId }).HasName("PK_HighScore");

            entity.HasOne(d => d.Game).WithMany(p => p.HighScores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HighScore_Game");

            entity.HasOne(d => d.Player).WithMany(p => p.HighScores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HighScore_Player");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.Property(e => e.Name).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
