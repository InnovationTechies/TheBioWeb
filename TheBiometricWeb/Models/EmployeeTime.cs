//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheBiometricWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeTime
    {
        public int EmpTimeID { get; set; }
        public Nullable<System.DateTime> EmpDate { get; set; }
        public Nullable<System.TimeSpan> EmpClockIn { get; set; }
        public Nullable<System.TimeSpan> EmpClockOut { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<bool> Present { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}