using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDuesHistory
    {
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string Transdate { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public string HireItemId { get; set; }
        public decimal? HireItemValue { get; set; }
        public decimal? HireItemValueNew { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public decimal? RecIdOrg { get; set; }
        public string GradeJobId { get; set; }
        public string GradeId { get; set; }
        public string InsTransUser { get; set; }
        public DateTime? InsTransDate { get; set; }
        public byte? RecStatus { get; set; }
        public string RowState { get; set; }
        public string GradeJobIdNew { get; set; }
        public string GradeIdNew { get; set; }
    }
}
