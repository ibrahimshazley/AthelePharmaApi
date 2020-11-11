using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpBorrowDtls
    {
        public Guid DtlsId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid HdrId { get; set; }
        public string BorrowMonthNo { get; set; }
        public decimal? BorrowMonthValue { get; set; }
        public byte BorrowMonthStatus { get; set; }
        public byte RowId { get; set; }

        public virtual HrEmpBorrowHdr HrEmpBorrowHdr { get; set; }
    }
}
