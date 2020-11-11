using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDocsDtlsHistory
    {
        public Guid DtlsId { get; set; }
        public Guid? HdrId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string FromDateHijri { get; set; }
        public string ToDateHijri { get; set; }
        public decimal ToBeNotifyPeriodBefore { get; set; }
        public byte NotifyPeriodType { get; set; }
        public decimal? ResponsibleEmpIdToNotify { get; set; }
        public string NotifyMessage { get; set; }
        public string NotifyMessageEn { get; set; }
        public string ActuallDateNotification { get; set; }
        public string ActuallDateNotificationHijri { get; set; }
        public string UpdUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public Guid? ConfirmNotifyId { get; set; }
        public byte? MessageStatus { get; set; }
        public string ResponsibleEmail { get; set; }
        public DateTime? InsMessageDate { get; set; }
        public DateTime? UpdStatusDate { get; set; }
        public string IssuePlace { get; set; }
        public string IssueRegion { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpDocId { get; set; }
        public string EmpDocCode { get; set; }
        public string Notes { get; set; }
        public string DocTypeId { get; set; }
        public decimal? OwnerEmpDoc { get; set; }
        public byte UseNotifyDateType { get; set; }
        public string DocPath { get; set; }
        public string RegistrationNo { get; set; }
    }
}
