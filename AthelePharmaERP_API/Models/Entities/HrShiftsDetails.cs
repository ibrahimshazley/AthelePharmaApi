using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrShiftsDetails
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid DtlsId { get; set; }
        public string ShiftId { get; set; }
        public string PeriodNo { get; set; }
        public string PeriodName { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
    }
}
