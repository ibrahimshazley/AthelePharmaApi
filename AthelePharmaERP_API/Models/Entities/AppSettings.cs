using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class AppSettings
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? EmpSerialForDocNotify { get; set; }
        public byte? CalcWithGrade { get; set; }
        public byte? UseTimeInWorkFlowRequest { get; set; }
        public decimal? PerioddayToForwordRequest { get; set; }
        public decimal? WorkingHoursPerDay { get; set; }
        public byte? ApplyPermissionDiscount { get; set; }
        public decimal? PeriodDayToNotifyFinishContract { get; set; }
        public string PayrollDay { get; set; }
        public decimal? AllowedPeriodForStopRequestEffect { get; set; }
        public string VacAllownaceBorA { get; set; }
        public byte? ChkVacAfterMonth { get; set; }
        public byte? ChkPaidByLastSal { get; set; }
        public byte? ChkAbilityTransferVac { get; set; }
        public byte? ChkAbilityTrncferToNext { get; set; }
        public decimal? MaxTrnsferPeriod { get; set; }
        public string VacAllownceSalaryItem { get; set; }
        public string VacTransferAllownceSalaryItem { get; set; }
        public string AbsenceSalaryItem { get; set; }
        public string DelySalaryItem { get; set; }
        public string ExtraSalaryItem { get; set; }
        public string VacTicketHireItemId { get; set; }
        public decimal? AbsenceCalcWayByDay { get; set; }
    }
}
