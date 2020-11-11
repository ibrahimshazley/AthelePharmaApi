using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpResignationRecord
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
        public string ResignationDate { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
