using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAlternativeEmployeesTrans
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string JobId { get; set; }
        public decimal? AlternateEmpSerialNo { get; set; }
        public string AlternateJobId { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
    }
}
