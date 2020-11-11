using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrFingerPrint
    {
        public Guid RecId { get; set; }
        public string Irow { get; set; }
        public string TmachineNumber { get; set; }
        public string EnrollNumber { get; set; }
        public string VerifyMode { get; set; }
        public string InOutMode { get; set; }
        public string DateTimeEnroll { get; set; }
        public string MonthYearNo { get; set; }
        public DateTime? InsDate { get; set; }
        public string YearNo { get; set; }
        public string MonthNo { get; set; }
        public string DayNo { get; set; }
        public string HourNo { get; set; }
        public string MinuteNo { get; set; }
    }
}
