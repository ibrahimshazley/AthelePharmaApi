using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class WorkFlowDtls
    {
        public decimal DtlsId { get; set; }
        public string WorkFlowId { get; set; }
        public string JobId { get; set; }
        public byte WorkFlowOrder { get; set; }

        public virtual WorkFlowHdr WorkFlow { get; set; }
    }
}
