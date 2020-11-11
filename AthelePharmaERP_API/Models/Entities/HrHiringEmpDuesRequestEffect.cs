using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringEmpDuesRequestEffect
    {
        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public string MonthNo { get; set; }
        public string TransDate { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public Guid? RequestHdrId { get; set; }
        public string HireItemId { get; set; }
        public byte? HireItemType { get; set; }
        public decimal? HireItemValue { get; set; }
        public Guid? RequestDtlsId { get; set; }
    }
}
