namespace TheBiometricWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TheCitiModels : DbContext
    {
        public TheCitiModels()
            : base("name=CitiInternDBEntities")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeTime> EmployeeTimes { get; set; }
        public virtual DbSet<EmpType> EmpTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Pin)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FingerPrint)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CellNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Region)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.ID_No)
                .IsUnicode(false);

            modelBuilder.Entity<EmpType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<EmpType>()
                .Property(e => e.Desc)
                .IsFixedLength();

            modelBuilder.Entity<EmpType>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EmpType1)
                .HasForeignKey(e => e.EmpType);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegName)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .Property(e => e.RegDesc)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
