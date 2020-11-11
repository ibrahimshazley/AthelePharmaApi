using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrShiftWeekDaysDtls
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid ShiftHdrId { get; set; }
        public string WeekSysDayId { get; set; }
        public string DayTypeId { get; set; }
    }
}
