using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployees
    {
        public HrEmployees()
        {
            HrEmpAbsenceRecord = new HashSet<HrEmpAbsenceRecord>();
            HrEmpAnnualLeavePlanRecord = new HashSet<HrEmpAnnualLeavePlanRecord>();
            HrEmpAnnualLeavePlanRequest = new HashSet<HrEmpAnnualLeavePlanRequest>();
            HrEmpAssets = new HashSet<HrEmpAssets>();
            HrEmpBorrowDelayRecord = new HashSet<HrEmpBorrowDelayRecord>();
            HrEmpBorrowDelayRequest = new HashSet<HrEmpBorrowDelayRequest>();
            HrEmpBorrowRequest = new HashSet<HrEmpBorrowRequest>();
            HrEmpCertifications = new HashSet<HrEmpCertifications>();
            HrEmpDelayRecord = new HashSet<HrEmpDelayRecord>();
            HrEmpDisciplinaryProcedureRecord = new HashSet<HrEmpDisciplinaryProcedureRecord>();
            HrEmpDisciplinaryProcedureRequest = new HashSet<HrEmpDisciplinaryProcedureRequest>();
            HrEmpDismissalRecord = new HashSet<HrEmpDismissalRecord>();
            HrEmpDismissalRequest = new HashSet<HrEmpDismissalRequest>();
            HrEmpDocsHdr = new HashSet<HrEmpDocsHdr>();
            HrEmpEmploymentRecord = new HashSet<HrEmpEmploymentRecord>();
            HrEmpEmploymentRequest = new HashSet<HrEmpEmploymentRequest>();
            HrEmpExperiences = new HashSet<HrEmpExperiences>();
            HrEmpExtraRecord = new HashSet<HrEmpExtraRecord>();
            HrEmpJobMissionRecord = new HashSet<HrEmpJobMissionRecord>();
            HrEmpJobMissionRequest = new HashSet<HrEmpJobMissionRequest>();
            HrEmpOtherMonthlyValueRecord = new HashSet<HrEmpOtherMonthlyValueRecord>();
            HrEmpOverTimeOrder = new HashSet<HrEmpOverTimeOrder>();
            HrEmpOverTimeRecord = new HashSet<HrEmpOverTimeRecord>();
            HrEmpOverTimeRequest = new HashSet<HrEmpOverTimeRequest>();
            HrEmpPermissionOrder = new HashSet<HrEmpPermissionOrder>();
            HrEmpPermissionRecord = new HashSet<HrEmpPermissionRecord>();
            HrEmpPermissionRequest = new HashSet<HrEmpPermissionRequest>();
            HrEmpQualifications = new HashSet<HrEmpQualifications>();
            HrEmpResignationRecord = new HashSet<HrEmpResignationRecord>();
            HrEmpResignationRequest = new HashSet<HrEmpResignationRequest>();
            HrEmpRewardRecord = new HashSet<HrEmpRewardRecord>();
            HrEmpRewardRequest = new HashSet<HrEmpRewardRequest>();
            HrEmpSecondmentRecord = new HashSet<HrEmpSecondmentRecord>();
            HrEmpSecondmentRequest = new HashSet<HrEmpSecondmentRequest>();
            HrEmpSkills = new HashSet<HrEmpSkills>();
            HrEmpTransferEmployeeRecord = new HashSet<HrEmpTransferEmployeeRecord>();
            HrEmpTransferEmployeeRequest = new HashSet<HrEmpTransferEmployeeRequest>();
            HrEmpTravelTickectRecord = new HashSet<HrEmpTravelTickectRecord>();
            HrEmpTravelTickectRequest = new HashSet<HrEmpTravelTickectRequest>();
            HrEmpVactionOrder = new HashSet<HrEmpVactionOrder>();
            HrEmpVactionRecord = new HashSet<HrEmpVactionRecord>();
            HrEmpVactionRequest = new HashSet<HrEmpVactionRequest>();
        }

        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string EmpId { get; set; }
        public string EmpCode { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpMeduimName { get; set; }
        public string EmpGrandFatherName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstNameEn { get; set; }
        public string EmpMeduimNameEn { get; set; }
        public string EmpGrandFatherNameEn { get; set; }
        public string EmpLastNameEn { get; set; }
        public string EmpLastNameConv { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string HireDate { get; set; }
        public string SocialStatusId { get; set; }
        public string MilitaryStatusId { get; set; }
        public string GenederId { get; set; }
        public string ReligionId { get; set; }
        public string CounteryId { get; set; }
        public string CityId { get; set; }
        public string NationalityId { get; set; }
        public string ProjectId { get; set; }
        public string ContractId { get; set; }
        public string AdminId { get; set; }
        public string DeptId { get; set; }
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public string GradeId { get; set; }
        public string QualifyTypeId { get; set; }
        public string QualifyId { get; set; }
        public string ShiftId { get; set; }
        public string IdentityTypeId { get; set; }
        public string IdentityNo { get; set; }
        public string IdentityStartDate { get; set; }
        public string IdentityStartDateHijri { get; set; }
        public string IdentityEndDate { get; set; }
        public string IdentityEndDateHijri { get; set; }
        public string InsidePhone { get; set; }
        public string InsideMobile1 { get; set; }
        public string InsideMobile2 { get; set; }
        public string OutsidePhone1 { get; set; }
        public string OutsideMobile1 { get; set; }
        public string OutsideMobile2 { get; set; }
        public string Fax { get; set; }
        public string InsideAddress1 { get; set; }
        public string InsideAddress2 { get; set; }
        public string OutsideAddress1 { get; set; }
        public string OutsideAddress2 { get; set; }
        public string BusinessEmail { get; set; }
        public string PrivateEmail { get; set; }
        public string ManagerId { get; set; }
        public string BankNo1 { get; set; }
        public string AccountBankNo1 { get; set; }
        public string IbanNo1 { get; set; }
        public string BankNo2 { get; set; }
        public string AccountBankNo2 { get; set; }
        public string IbanNo2 { get; set; }
        public byte? HasFingerPrint { get; set; }
        public byte? HasAbsence { get; set; }
        public byte? HasOverTime { get; set; }
        public byte? HasDelay { get; set; }
        public byte? HasPermission { get; set; }
        public byte? HasMedicalInsurance { get; set; }
        public string MedicalInsuranceNo { get; set; }
        public string MedicalInsuranceStartDate { get; set; }
        public string MedicalInsuranceStartDateHijri { get; set; }
        public string MedicalInsuranceEndDate { get; set; }
        public string MedicalInsuranceEndDateHijri { get; set; }
        public string SocialInsuranceNo { get; set; }
        public string Notes { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public string FullNameArabic { get; set; }
        public string FullNameEn { get; set; }
        public string ImagePath { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssueDate { get; set; }
        public string PassportExpiryDate { get; set; }
        public byte? IsCommissioner { get; set; }
        public decimal? CommissionerSerialNo { get; set; }
        public byte? NeedMandate { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string GradeJobId { get; set; }
        public string EmpStatusId { get; set; }
        public byte? HasManager { get; set; }
        public string ContractClassify { get; set; }
        public string StartContract { get; set; }
        public string EndContract { get; set; }
        public decimal? ContractPeriodByMonth { get; set; }
        public byte? IsEmpManager { get; set; }
        public string WorkStartingDate { get; set; }
        public string WorkStartingDateAfterRenwal { get; set; }
        public byte? DeductInsurance { get; set; }
        public string EnrollFpnumber { get; set; }
        public string AttendanceType { get; set; }
        public string DeliverSalType { get; set; }

        public virtual HrCompanies Company { get; set; }
        public virtual HrBranches HrBranches { get; set; }
        public virtual ICollection<HrEmpAbsenceRecord> HrEmpAbsenceRecord { get; set; }
        public virtual ICollection<HrEmpAnnualLeavePlanRecord> HrEmpAnnualLeavePlanRecord { get; set; }
        public virtual ICollection<HrEmpAnnualLeavePlanRequest> HrEmpAnnualLeavePlanRequest { get; set; }
        public virtual ICollection<HrEmpAssets> HrEmpAssets { get; set; }
        public virtual ICollection<HrEmpBorrowDelayRecord> HrEmpBorrowDelayRecord { get; set; }
        public virtual ICollection<HrEmpBorrowDelayRequest> HrEmpBorrowDelayRequest { get; set; }
        public virtual ICollection<HrEmpBorrowRequest> HrEmpBorrowRequest { get; set; }
        public virtual ICollection<HrEmpCertifications> HrEmpCertifications { get; set; }
        public virtual ICollection<HrEmpDelayRecord> HrEmpDelayRecord { get; set; }
        public virtual ICollection<HrEmpDisciplinaryProcedureRecord> HrEmpDisciplinaryProcedureRecord { get; set; }
        public virtual ICollection<HrEmpDisciplinaryProcedureRequest> HrEmpDisciplinaryProcedureRequest { get; set; }
        public virtual ICollection<HrEmpDismissalRecord> HrEmpDismissalRecord { get; set; }
        public virtual ICollection<HrEmpDismissalRequest> HrEmpDismissalRequest { get; set; }
        public virtual ICollection<HrEmpDocsHdr> HrEmpDocsHdr { get; set; }
        public virtual ICollection<HrEmpEmploymentRecord> HrEmpEmploymentRecord { get; set; }
        public virtual ICollection<HrEmpEmploymentRequest> HrEmpEmploymentRequest { get; set; }
        public virtual ICollection<HrEmpExperiences> HrEmpExperiences { get; set; }
        public virtual ICollection<HrEmpExtraRecord> HrEmpExtraRecord { get; set; }
        public virtual ICollection<HrEmpJobMissionRecord> HrEmpJobMissionRecord { get; set; }
        public virtual ICollection<HrEmpJobMissionRequest> HrEmpJobMissionRequest { get; set; }
        public virtual ICollection<HrEmpOtherMonthlyValueRecord> HrEmpOtherMonthlyValueRecord { get; set; }
        public virtual ICollection<HrEmpOverTimeOrder> HrEmpOverTimeOrder { get; set; }
        public virtual ICollection<HrEmpOverTimeRecord> HrEmpOverTimeRecord { get; set; }
        public virtual ICollection<HrEmpOverTimeRequest> HrEmpOverTimeRequest { get; set; }
        public virtual ICollection<HrEmpPermissionOrder> HrEmpPermissionOrder { get; set; }
        public virtual ICollection<HrEmpPermissionRecord> HrEmpPermissionRecord { get; set; }
        public virtual ICollection<HrEmpPermissionRequest> HrEmpPermissionRequest { get; set; }
        public virtual ICollection<HrEmpQualifications> HrEmpQualifications { get; set; }
        public virtual ICollection<HrEmpResignationRecord> HrEmpResignationRecord { get; set; }
        public virtual ICollection<HrEmpResignationRequest> HrEmpResignationRequest { get; set; }
        public virtual ICollection<HrEmpRewardRecord> HrEmpRewardRecord { get; set; }
        public virtual ICollection<HrEmpRewardRequest> HrEmpRewardRequest { get; set; }
        public virtual ICollection<HrEmpSecondmentRecord> HrEmpSecondmentRecord { get; set; }
        public virtual ICollection<HrEmpSecondmentRequest> HrEmpSecondmentRequest { get; set; }
        public virtual ICollection<HrEmpSkills> HrEmpSkills { get; set; }
        public virtual ICollection<HrEmpTransferEmployeeRecord> HrEmpTransferEmployeeRecord { get; set; }
        public virtual ICollection<HrEmpTransferEmployeeRequest> HrEmpTransferEmployeeRequest { get; set; }
        public virtual ICollection<HrEmpTravelTickectRecord> HrEmpTravelTickectRecord { get; set; }
        public virtual ICollection<HrEmpTravelTickectRequest> HrEmpTravelTickectRequest { get; set; }
        public virtual ICollection<HrEmpVactionOrder> HrEmpVactionOrder { get; set; }
        public virtual ICollection<HrEmpVactionRecord> HrEmpVactionRecord { get; set; }
        public virtual ICollection<HrEmpVactionRequest> HrEmpVactionRequest { get; set; }
    }
}
