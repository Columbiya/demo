using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ItPlus.Model;

public partial class ItPlusContext : DbContext
{
    public ItPlusContext()
    {
    }

    public ItPlusContext(DbContextOptions<ItPlusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestStatus> RequestStatuses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;user=root;password=1234;database=it_plus", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Idcomments).HasName("PRIMARY");

            entity.ToTable("comments");

            entity.HasIndex(e => e.Author, "author_idx");

            entity.HasIndex(e => e.Request, "request_idx");

            entity.Property(e => e.Idcomments)
                .ValueGeneratedNever()
                .HasColumnName("idcomments");
            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.Request).HasColumnName("request");
            entity.Property(e => e.Text).HasColumnName("text");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("author");

            entity.HasOne(d => d.RequestNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Request)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("request");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("PRIMARY");

            entity.ToTable("device_type");

            entity.Property(e => e.IdType).HasColumnName("id_type");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.IdRequest).HasName("PRIMARY");

            entity.ToTable("request");

            entity.HasIndex(e => e.ResponseEemployee, "response_idx");

            entity.HasIndex(e => e.Status, "status_idx");

            entity.HasIndex(e => e.DeviceType, "type_device_idx");

            entity.HasIndex(e => e.User, "users_idx");

            entity.Property(e => e.IdRequest)
                .ValueGeneratedNever()
                .HasColumnName("id_request");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("date_end");
            entity.Property(e => e.DescriptionProblem).HasColumnName("description_problem");
            entity.Property(e => e.DeviceType).HasColumnName("device_type");
            entity.Property(e => e.ModelDevice)
                .HasMaxLength(45)
                .HasColumnName("model_device");
            entity.Property(e => e.ResponseEemployee).HasColumnName("response_eemployee");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.DeviceTypeNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.DeviceType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("type_device");

            entity.HasOne(d => d.ResponseEemployeeNavigation).WithMany(p => p.RequestResponseEemployeeNavigations)
                .HasForeignKey(d => d.ResponseEemployee)
                .HasConstraintName("response");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.RequestUserNavigations)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users");
        });

        modelBuilder.Entity<RequestStatus>(entity =>
        {
            entity.HasKey(e => e.IdrequestStatus).HasName("PRIMARY");

            entity.ToTable("request_status");

            entity.Property(e => e.IdrequestStatus)
                .ValueGeneratedNever()
                .HasColumnName("idrequest_status");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUsers).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "login_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Role, "role_idx");

            entity.Property(e => e.IdUsers).HasColumnName("id_users");
            entity.Property(e => e.Firstname)
                .HasMaxLength(30)
                .HasColumnName("firstname");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(30)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Telephone)
                .HasMaxLength(20)
                .HasColumnName("telephone");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
