using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrShiftGroups
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string ShiftGroupId { get; set; }
        public string ShiftGroupName { get; set; }
        public string ShiftGroupNameEn { get; set; }
        public string ShiftGroupShortName { get; set; }
        public string ShiftGroupNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }

        public virtual HrBranches HrBranches { get; set; }
    }
}
