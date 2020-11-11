using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrShifts
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string ShiftId { get; set; }
        public Guid? ShiftHdrId { get; set; }
        public string ShiftName { get; set; }
        public string ShiftNameEn { get; set; }
        public string ShortName { get; set; }
        public string ShiftNameConv { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public decimal? ShiftDurationByMin { get; set; }
        public string BreakFromTime { get; set; }
        public string BreakToTime { get; set; }
        public decimal? BreakDurationByMin { get; set; }
        public decimal? AllowedPeriodToCalcByMin { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string ShiftGroupId { get; set; }

        public virtual HrCompanies Company { get; set; }
        public virtual HrBranches HrBranches { get; set; }
    }
}
