namespace TheBiometricWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            EmployeeTimes = new HashSet<EmployeeTime>();
        }

        [Key]
        public int EmpID { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Pin { get; set; }

        [StringLength(50)]
        public string FingerPrint { get; set; }

        [StringLength(10)]
        public string CellNumber { get; set; }

        [StringLength(10)]
        public string Region { get; set; }

        [StringLength(13)]
        public string ID_No { get; set; }

        public int? EmpType { get; set; }

        [Column(TypeName = "image")]
        public byte[] EmpImage { get; set; }

        public bool? Present { get; set; }

        public virtual EmpType EmpType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTime> EmployeeTimes { get; set; }
    }
}
