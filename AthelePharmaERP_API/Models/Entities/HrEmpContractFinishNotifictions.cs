using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpContractFinishNotifictions
    {
        public decimal RecNotifyNo { get; set; }
        public Guid NotifyHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string FinishMonthNo { get; set; }
        public Guid? RecContractHdrId { get; set; }
        public DateTime InsDate { get; set; }
        public decimal? ResponsibleEmpIdToNotify { get; set; }
        public string NotifyMessage { get; set; }
        public string NotifyMessageEn { get; set; }
        public string EndContract { get; set; }
    }
}
