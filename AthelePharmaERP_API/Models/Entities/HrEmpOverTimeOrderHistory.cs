using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpOverTimeOrderHistory
    {
        public Guid HdrId { get; set; }
        public decimal RecNo { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public decimal OrderNo { get; set; }
        public byte OrderStatus { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public DateTime? InsDate { get; set; }
    }
}
