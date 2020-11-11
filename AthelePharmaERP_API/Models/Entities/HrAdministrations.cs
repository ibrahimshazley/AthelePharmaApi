using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAdministrations
    {
        public HrAdministrations()
        {
            HrDepartments = new HashSet<HrDepartments>();
        }

        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string AdminId { get; set; }
        public string AdminCode { get; set; }
        public string AdminName { get; set; }
        public string AdminNameEn { get; set; }
        public string AdminNameConv { get; set; }
        public string AdminAccountNo { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public decimal Id { get; set; }
        public byte? IsParent { get; set; }
        public byte? HasParent { get; set; }
        public string ParentAdminId { get; set; }

        public virtual HrBranches HrBranches { get; set; }
        public virtual ICollection<HrDepartments> HrDepartments { get; set; }
    }
}
