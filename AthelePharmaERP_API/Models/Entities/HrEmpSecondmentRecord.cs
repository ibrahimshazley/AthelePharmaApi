using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpSecondmentRecord
    {
        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public string RequestId { get; set; }
        public string RecOrderNo { get; set; }
        public Guid? RecOrderHdrId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public string FromSecondmentDate { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string ToSecondmentDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal? ExpectedValue { get; set; }
        public string Notes { get; set; }
        public string SecondmentType { get; set; }
        public decimal? DailySecondmentValue { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
