using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringMonthDelayDuesDtls
    {
        public Guid DtlsId { get; set; }
        public Guid RecHdrId { get; set; }
        public string HireItemId { get; set; }
        public byte HireItemType { get; set; }
        public decimal HireItemDuesValue { get; set; }
        public byte HireItemStatus { get; set; }

        public virtual HrHiringMonthDelayDuesHdr RecHdr { get; set; }
    }
}
