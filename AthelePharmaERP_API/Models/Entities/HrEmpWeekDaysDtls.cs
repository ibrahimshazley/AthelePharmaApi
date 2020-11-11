using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpWeekDaysDtls
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid EmpHdrId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string WeekSysDayId { get; set; }
        public string DayTypeId { get; set; }
    }
}
