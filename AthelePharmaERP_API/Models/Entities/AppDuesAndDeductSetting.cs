using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class AppDuesAndDeductSetting
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string AppSettingType { get; set; }
        public byte? CalcOnType { get; set; }
        public string HireItemId { get; set; }
        public byte? CheckedStatus { get; set; }
    }
}
