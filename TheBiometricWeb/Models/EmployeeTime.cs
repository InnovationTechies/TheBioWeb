namespace TheBiometricWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTime")]
    public partial class EmployeeTime
    {
        [Key]
        public int EmpTimeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmpDate { get; set; }

        public TimeSpan? EmpClockIn { get; set; }

        public TimeSpan? EmpClockOut { get; set; }

        public int? EmpID { get; set; }

        public bool? Present { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
