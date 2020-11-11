using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class VwInsertVactionRequestSteps
    {
        public string RequestId { get; set; }
        public string JobId { get; set; }
        public byte WorkFlowOrder { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowNameEn { get; set; }
        public byte RecStatus { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string FullNameArabic { get; set; }
        public string FullNameEn { get; set; }
        public string JobName { get; set; }
        public string JobNameEn { get; set; }
    }
}
