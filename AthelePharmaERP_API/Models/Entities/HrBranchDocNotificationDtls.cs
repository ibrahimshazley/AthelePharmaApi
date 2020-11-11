using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranchDocNotificationDtls
    {
        public decimal NotifyRecHdrId { get; set; }
        public Guid ConfirmNotifyId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid BranchDocDtlsId { get; set; }
        public byte? MessageStatus { get; set; }
        public string ResponsibleEmail { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public string NotifyMessage { get; set; }
        public string NotifyMessageEn { get; set; }
        public DateTime InsDate { get; set; }
        public string DocTypeId { get; set; }
    }
}
