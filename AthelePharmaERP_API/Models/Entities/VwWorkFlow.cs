using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class VwWorkFlow
    {
        public string WorkFlowId { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
