using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrDepartments
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string DeptId { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptNameEn { get; set; }
        public string DeptNameConv { get; set; }
        public string DeptAccountNo { get; set; }
        public string AdminId { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public decimal Id { get; set; }

        public virtual HrAdministrations HrAdministrations { get; set; }
    }
}
