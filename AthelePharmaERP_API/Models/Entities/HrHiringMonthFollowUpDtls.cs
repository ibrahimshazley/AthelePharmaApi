using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringMonthFollowUpDtls
    {
        public Guid DtlsId { get; set; }
        public Guid RecHdrId { get; set; }
        public string HireItemId { get; set; }
        public byte HireItemType { get; set; }
        public decimal HireItemValue { get; set; }
        public decimal HireItemActuallValue { get; set; }
        public decimal HireItemDiffValue { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? RecEmpDuesHdrId { get; set; }
        public Guid? RecRequestHdrId { get; set; }

        public virtual HrHiringMonthFollowUpHdr RecHdr { get; set; }
    }
}
