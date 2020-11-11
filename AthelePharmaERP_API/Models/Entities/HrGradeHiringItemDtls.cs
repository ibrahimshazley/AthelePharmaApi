using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrGradeHiringItemDtls
    {
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string GradeId { get; set; }
        public decimal DtlsId { get; set; }
        public string HireItemId { get; set; }
        public byte HireItemValueType { get; set; }
        public decimal HireItemValue { get; set; }
    }
}
