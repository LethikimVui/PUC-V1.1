using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedObjects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base()
        {

        }

        public ApplicationDbContext()
        {
        }

        //Scaffold-DbContext "Data Source=VNHCMC0SQL81;Initial Catalog=PUC;User Id=PUC_User;Password=PUC!@#123;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -Tables "Request" -OutputDir Models2
        public virtual DbSet<Main> Main { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<AccessUserRole> AccessUserRole { get; set; }
        public virtual DbSet<MasterCategory> MasterCategory { get; set; }
        public virtual DbSet<MasterReason> MasterReason { get; set; }
        public virtual DbSet<MasterSupplier> MasterSupplier { get; set; }
        public virtual DbSet<MasterApproval> MasterApproval { get; set; }
        public virtual DbSet<Request> Request { get; set; }

        public virtual DbQuery<VMain> Part { get; set; }
        public virtual DbQuery<VDetail> VDetail { get; set; }
        public virtual DbQuery<VCategory> VCategory { get; set; }
        public virtual DbQuery<VCount> VCount { get; set; }
        public virtual DbQuery<VCustomer> VCustomer { get; set; }
        public virtual DbQuery<VMachineName> VMachineName { get; set; }
        public virtual DbQuery<VReason> VReason { get; set; }
        public virtual DbQuery<VRole> VRole { get; set; }
        public virtual DbQuery<VStatus> VStatus { get; set; }
        public virtual DbQuery<VSupplier> VSupplier { get; set; }
        public virtual DbQuery<VUser> VUser { get; set; }
        public virtual DbQuery<VUserRole> VUserRole { get; set; }
        public virtual DbQuery<VLog> VLog { get; set; }
        public virtual DbQuery<VRequest> VRequest { get; set; }
        public virtual DbQuery<VRequestDetail> VRequestDetail { get; set; }
        public virtual DbQuery<VTicket> VTicket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data Source=VNHCMC0SQL81;Initial Catalog=TE_HCS;User Id=TE_HCS_USER;Password=Zxcvbnm123!@;MultipleActiveResultSets=true;");
                optionsBuilder.UseSqlServer("Data Source=VNHCMC0SQL81;Initial Catalog=PUC;User Id=PUC_User;Password=PUC!@#123;MultipleActiveResultSets=true;");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Main>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MachineName)
                    .HasColumnName("machineName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serialNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AccessUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("Access_UserRole");

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Ntlogin)
                    .HasColumnName("NTLogin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantID");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.DetailId).HasColumnName("detailId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Limit).HasColumnName("limit");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.TriggerLimit).HasColumnName("triggerLimit");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsedTimes).HasColumnName("used_times");
            });
            modelBuilder.Entity<MasterCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Master_Category");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<MasterSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("Master_Supplier");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<MasterReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("Master_Reason");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<MasterApproval>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("Master_Approval");

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Ntlogin)
                    .HasColumnName("NTLogin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantID");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.ReqId);

                entity.Property(e => e.ReqId).HasColumnName("reqId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DetailId).HasColumnName("detailId");

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Limit).HasColumnName("limit");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.ReqNumber)
                    .HasColumnName("reqNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.TriggerLimit).HasColumnName("triggerLimit");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(50);
            });
        }


    }
}
