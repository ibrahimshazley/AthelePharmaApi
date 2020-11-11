using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpBorrowDelayRequestWorkFlow
    {
        public Guid DtlsId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid? HdrId { get; set; }
        public string RequestType { get; set; }
        public string ReferenceNo { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string JobId { get; set; }
        public byte WorkFlowOrder { get; set; }
        public byte EmpReplay { get; set; }
        public string RequestStatus { get; set; }
        public string EmpComment { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string EmpNameReplay { get; set; }
        public DateTime? DateReplay { get; set; }
        public DateTime? MaxiumDateReplay { get; set; }
        public string Notes { get; set; }
        public decimal? AlternateEmpSerialNo { get; set; }
        public string AlternateJobId { get; set; }
    }
}
