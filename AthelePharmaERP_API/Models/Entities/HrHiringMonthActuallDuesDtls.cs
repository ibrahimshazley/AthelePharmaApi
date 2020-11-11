using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringMonthActuallDuesDtls
    {
        public Guid DtlsId { get; set; }
        public Guid RecHdrId { get; set; }
        public string HireItemId { get; set; }
        public byte HireItemType { get; set; }
        public decimal HireItemActuallValue { get; set; }

        public virtual HrHiringMonthActuallDuesHdr RecHdr { get; set; }
    }
}
