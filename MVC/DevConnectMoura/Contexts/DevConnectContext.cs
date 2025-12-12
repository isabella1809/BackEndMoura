using System;
using System.Collections.Generic;
using DevConnectMoura.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FA03CFEA4");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_pu__5535A963");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_us__5441852A");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tb_curti__3213E83F669DAC92");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tb_curtid__id_pu__5165187F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tb_curtid__id_us__5070F446");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83FFF28EFD7");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__4D94879B");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83F725CA40E");

            entity.HasMany(d => d.IdSeguindo).WithMany(p => p.IdUsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__59063A47"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5812160E"),
                    j =>
                    {
                        j.HasKey("IdSeguindo", "IdUsuarioSeguidor").HasName("PK__tb_segui__DC54F8D8D153EC80");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdSeguindo").HasColumnName("id_seguindo");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                    });

            entity.HasMany(d => d.IdUsuarioSeguidor).WithMany(p => p.IdSeguindo)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5812160E"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__59063A47"),
                    j =>
                    {
                        j.HasKey("IdSeguindo", "IdUsuarioSeguidor").HasName("PK__tb_segui__DC54F8D8D153EC80");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdSeguindo").HasColumnName("id_seguindo");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
