using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrFpmodeStatus
    {
        public string WeekSysDayId { get; set; }
        public string WeekSysDayName { get; set; }
        public string WeekSysDayNameEn { get; set; }
        public string EffectType { get; set; }
        public string DefaultEffect { get; set; }
    }
}
