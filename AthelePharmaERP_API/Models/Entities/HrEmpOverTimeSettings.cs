using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpOverTimeSettings
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? CalcHourInWorkingDay { get; set; }
        public decimal? CalcHourInVactionDay { get; set; }
    }
}
