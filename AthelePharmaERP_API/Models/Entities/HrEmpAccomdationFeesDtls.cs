using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpAccomdationFeesDtls
    {
        public Guid DtlsId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid HdrId { get; set; }
        public string AccomdtionFeeMonthNo { get; set; }
        public decimal? AccomdtionFeeMonthValue { get; set; }
        public byte AccomdtionFeeMonthStatus { get; set; }
        public byte RowId { get; set; }
    }
}
