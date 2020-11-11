using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpPermissionSettings
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? AllowedValueInMonthByHour { get; set; }
        public decimal? AllowedValueInDayByHour { get; set; }
        public decimal? PeriodForDay { get; set; }
        public decimal? HourNoForDiscount { get; set; }
        public byte? AllowToExceedMonthValue { get; set; }
        public byte? AllowToExceedDayValue { get; set; }
        public byte? OnlyApplyDiscount { get; set; }
    }
}
