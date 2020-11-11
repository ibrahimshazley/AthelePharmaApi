using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class WorkFlowHdr
    {
        public WorkFlowHdr()
        {
            WorkFlowDtls = new HashSet<WorkFlowDtls>();
        }

        public decimal RecId { get; set; }
        public string WorkFlowId { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowNameEn { get; set; }
        public string WorkFlowNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }

        public virtual ICollection<WorkFlowDtls> WorkFlowDtls { get; set; }
    }
}
