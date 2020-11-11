using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class VwEmpTicketValueForAllEmployee
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string HireItemId { get; set; }
        public decimal HireItemValue { get; set; }
    }
}
