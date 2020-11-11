using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranchDocsHdr
    {
        public Guid HdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal BranchDocId { get; set; }
        public string BranchDocCode { get; set; }
        public string DocTypeId { get; set; }
        public string LastFromDate { get; set; }
        public string LastToDate { get; set; }
        public string LastFromDateHijri { get; set; }
        public string LastToDateHijri { get; set; }
        public decimal ToBeNotifyPeriodBefore { get; set; }
        public byte NotifyPeriodType { get; set; }
        public decimal? ResponsibleEmpIdToNotify { get; set; }
        public string NotifyMessage { get; set; }
        public string NotifyMessageEn { get; set; }
        public string ActuallDateNotification { get; set; }
        public string ActuallDateNotificationHijri { get; set; }
        public string UseNotifyDateType { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string IssuePlace { get; set; }
        public string IssueRegion { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? RecStatus { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string Notes { get; set; }
        public string DocPath { get; set; }
        public byte SendNotify { get; set; }
        public string RegistrationNo { get; set; }

        public virtual HrDocumentTypes DocType { get; set; }
        public virtual HrBranches HrBranches { get; set; }
    }
}
