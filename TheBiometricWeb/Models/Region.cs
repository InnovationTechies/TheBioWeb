namespace TheBiometricWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        [Key]
        public int RegID { get; set; }

        [StringLength(10)]
        public string RegName { get; set; }

        [StringLength(50)]
        public string RegDesc { get; set; }
    }
}
