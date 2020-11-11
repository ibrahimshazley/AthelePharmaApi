using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrInporgressAndApprovedRequests
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public Guid RecHdrId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string OrderStatus { get; set; }
        public string RequestGroupTypeId { get; set; }
        public string RequestId { get; set; }
        public DateTime? InsDate { get; set; }
    }
}
