using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpRequestNotify
    {
        public Guid NotifyHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid RequestHdrId { get; set; }
        public string RequestType { get; set; }
        public decimal EmpSerialNo { get; set; }
        public Guid DetailWorkFlowId { get; set; }
        public string JobName { get; set; }
        public string JobNameEn { get; set; }
        public string SenderName { get; set; }
        public string SenderNameEn { get; set; }
        public string CommissionerName { get; set; }
        public string CommissionerNameEn { get; set; }
        public DateTime? InsDate { get; set; }
        public DateTime? MaxiumDateReplay { get; set; }
        public decimal? AlternateEmpSerialNoNotify { get; set; }
    }
}
