using System;
using System.Collections.Generic;
using Conexion.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Conexion.Domain.DbContexto;

public partial class SysIturanContext : DbContext
{
    public SysIturanContext()
    {
    }

    public SysIturanContext(DbContextOptions<SysIturanContext> options)
        : base(options)
    {
    }

   

    public virtual DbSet<WebhookEven> WebhookEvens { get; set; }





    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<WebhookEven>(entity =>
        {
            entity.HasKey(e => e.LngId).HasName("PK__WebhookE__6656D98BDD4D3170");

            entity.ToTable("WebhookEven");

            entity.Property(e => e.LngId).HasColumnName("Lng_Id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Dispositivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesado).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orden)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vin)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
