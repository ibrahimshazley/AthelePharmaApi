using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpHiringMonthStatus
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal Id { get; set; }
        public string MonthNo { get; set; }
        public byte? PreparedIsDone { get; set; }
        public byte? AdoptedIsDone { get; set; }
    }
}
