using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrMilitaryStatuses
    {
        public string MilitaryStatusId { get; set; }
        public string MilitaryStatusName { get; set; }
        public string MilitaryStatusNameEn { get; set; }
        public string MilitaryStatusNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
