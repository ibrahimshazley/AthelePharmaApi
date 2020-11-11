using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrDailyTimeSheet
    {
        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string MonthNo { get; set; }
        public string Transdate { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string DayCode { get; set; }
        public string DayType { get; set; }
        public string ShiftId { get; set; }
        public string EmpCheckInTime { get; set; }
        public string EmpCheckOutTime { get; set; }
        public decimal? WorkingHours { get; set; }
        public decimal? DelyAmountInMinut { get; set; }
        public decimal? ExtraAmountInMinut { get; set; }
        public string ApplyDely { get; set; }
        public string ApplyExtra { get; set; }
        public string ApplyAbsence { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public byte? Confirmed { get; set; }
        public decimal? OvertimePeriodFrmRqustInMinute { get; set; }
        public decimal? PermissionPeriodFrmRqustInMinute { get; set; }
        public string EmpInVacation { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? DiffDelyInMinut { get; set; }
        public decimal? DiffExtraInMinut { get; set; }
    }
}
