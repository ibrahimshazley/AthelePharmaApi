using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpSpouses
    {
        public Guid DtlsId { get; set; }
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string SpouseNameArabic { get; set; }
        public string SpouseNameEn { get; set; }
        public string SpouseNameConv { get; set; }
        public string SpouseBithDate { get; set; }
        public string MarriedDate { get; set; }
        public string SpouseNationalityId { get; set; }
        public string SpousePassportNo { get; set; }
        public string SpousePassportIssueDate { get; set; }
        public string SpousePassportExpiryDate { get; set; }
        public string SpouseInsuranceNo { get; set; }
        public string SpouseInsuranceIssueDate { get; set; }
        public string SpouseInsuranceExpiryDate { get; set; }
        public string NationalId { get; set; }
        public string NationalStartDate { get; set; }
        public string NationalEndDate { get; set; }
        public string MarriedContractAttach { get; set; }
        public string SpouseNotes { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? RecStatus { get; set; }
        public string RowState { get; set; }
    }
}
