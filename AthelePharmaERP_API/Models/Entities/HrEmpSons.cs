using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpSons
    {
        public Guid DtlsId { get; set; }
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string SonNameArabic { get; set; }
        public string SonNameEn { get; set; }
        public string SonNameConv { get; set; }
        public string SonBithDate { get; set; }
        public string DeathDate { get; set; }
        public string SonNationalityId { get; set; }
        public string SonPassportNo { get; set; }
        public string SonPassportIssueDate { get; set; }
        public string SonPassportExpiryDate { get; set; }
        public string SonInsuranceNo { get; set; }
        public string SonInsuranceIssueDate { get; set; }
        public string SonInsuranceExpiryDate { get; set; }
        public string NationalId { get; set; }
        public string NationalStartDate { get; set; }
        public string NationalEndDate { get; set; }
        public string BirthCertificateAttach { get; set; }
        public string SonNotes { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? RecStatus { get; set; }
        public string RowState { get; set; }
        public string SonGenederId { get; set; }
        public string SonSocialStatusId { get; set; }
        public string SonQualifyId { get; set; }
        public string SonImageAttach { get; set; }
    }
}
