using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrWeekSysDays
    {
        public string WeekSysDayId { get; set; }
        public string WeekSysDayName { get; set; }
        public string WeekSysDayNameEn { get; set; }
        public string ShortName { get; set; }
        public string DayFirstInSqlCode { get; set; }
    }
}
