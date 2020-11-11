using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpBorrowSettings
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? AllowedValueNotExceedTo { get; set; }
        public byte? AllowExceedMaxValue { get; set; }
    }
}
