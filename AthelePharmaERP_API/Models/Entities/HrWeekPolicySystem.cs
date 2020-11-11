using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrWeekPolicySystem
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNameEn { get; set; }
        public string ShortName { get; set; }
        public decimal? WeekDays { get; set; }
        public decimal? WeekStartOn { get; set; }
        public string PartialDayBeginTime { get; set; }
        public string PartialDayEndTime { get; set; }
        public decimal? Pdduration { get; set; }
        public decimal? MinMinuteWorkingFromWeekOff { get; set; }
        public decimal? CalcHalfDayIfWorkingUpTo { get; set; }
        public decimal? CalcFullDayIfWorkingexceedsTo { get; set; }
        public decimal? AllowedPeriodSysToCalcByMin { get; set; }
        public decimal? FirstFpbeforeShiftByMin { get; set; }
        public decimal? LastFpafterShiftByMin { get; set; }
    }
}
