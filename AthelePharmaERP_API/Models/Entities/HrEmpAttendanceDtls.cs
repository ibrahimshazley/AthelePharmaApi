using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpAttendanceDtls
    {
        public Guid DtlsId { get; set; }
        public Guid RecHdrId { get; set; }
        public string EmpCheckInTime { get; set; }
        public string ShiftFromTime { get; set; }
        public string ShiftToTime { get; set; }
        public string EmpCheckOutTime { get; set; }
        public string ShiftId { get; set; }
        public string BeforeCheckIn { get; set; }
        public decimal? BeforeCheckInEffectInMin { get; set; }
        public string AfterCheckIn { get; set; }
        public decimal? AfterCheckInEffectInMin { get; set; }
        public string BeforeCheckOut { get; set; }
        public decimal? BeforeCheckOutEffectInMin { get; set; }
        public string AfterCheckOut { get; set; }
        public decimal? AfterCheckOutEffectInMin { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? WorkingPeriodWithShftInMinute { get; set; }

        public virtual HrEmpAttendanceHdr RecHdr { get; set; }
    }
}
