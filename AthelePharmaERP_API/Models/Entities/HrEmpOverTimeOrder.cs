using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpOverTimeOrder
    {
        public Guid RecHdrId { get; set; }
        public decimal RecNo { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public byte OverTimeTypeId { get; set; }
        public decimal OverTimePeriod { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public byte OrderStatus { get; set; }
        public string DirectManagerComment { get; set; }
        public decimal? DirectEmpSerialNo { get; set; }
        public string HrManagerComment { get; set; }
        public decimal? HrManagerSerialNo { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
