//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hr_AlternativeEmployeesTrans
    {
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public decimal Rec_id { get; set; }
        public decimal Emp_Serial_No { get; set; }
        public string Job_Id { get; set; }
        public Nullable<decimal> Alternate_Emp_Serial_No { get; set; }
        public string Alternate_Job_Id { get; set; }
        public string InsUser { get; set; }
        public Nullable<System.DateTime> InsDate { get; set; }
    }
}
