using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpSecondmentSetting
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string JobId { get; set; }
    }
}
