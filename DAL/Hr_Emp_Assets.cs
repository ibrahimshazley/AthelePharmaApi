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
    
    public partial class Hr_Emp_Assets
    {
        public System.Guid Hdr_Id { get; set; }
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public decimal Emp_Serial_No { get; set; }
        public decimal Reciept_No { get; set; }
        public string Transdate { get; set; }
        public decimal Asset_Group_Id { get; set; }
        public decimal Asset_Value { get; set; }
        public string InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Hr_Assets_Group Hr_Assets_Group { get; set; }
        public virtual Hr_Employees Hr_Employees { get; set; }
    }
}
