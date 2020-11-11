using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringEmpReceivableDuesDtls
    {
        public Guid DtlsId { get; set; }
        public Guid HdrId { get; set; }
        public string HireItemId { get; set; }
        public decimal HireItemValue { get; set; }
        public string TransItemDate { get; set; }
        public string DueDate { get; set; }
        public string InsItemUser { get; set; }
        public DateTime? InsItemDate { get; set; }
        public byte? Confirmed { get; set; }
        public Guid? RecEmpDuesHdrId { get; set; }
        public Guid? RecRequestHdrId { get; set; }
        public DateTime? ConfirmedUpdateDate { get; set; }
        public string ConfirmDate { get; set; }

        public virtual HrHiringEmpReceivableDuesHdr Hdr { get; set; }
    }
}
