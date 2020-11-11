using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAssignWorkFlowToRequest
    {
        public decimal RecId { get; set; }
        public string RequestId { get; set; }
        public string WorkFlowId { get; set; }
    }
}
