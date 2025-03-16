using System;
using System.Collections.Generic;
using Alcuino_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Alcuino_MVC.Context;

public partial class MyDBContext : DbContext
{
    public MyDBContext()
    {
    }

    public MyDBContext(DbContextOptions<MyDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NaStudent> NaStudents { get; set; }

    public virtual DbSet<NaUser> NaUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-G1BTJFD8;Initial Catalog=Alcuinoo_ProjectDB;Integrated Security=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NaStudent>(entity =>
        {
            entity.ToTable("NA_Student");

            entity.Property(e => e.Age).HasDefaultValue(16);
            entity.Property(e => e.Grade).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<NaUser>(entity =>
        {
            entity.ToTable("NA_User");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
