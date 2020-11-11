using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrRewardReasons
    {
        public string RewardReasonId { get; set; }
        public string RewardReasonName { get; set; }
        public string RewardReasonNameEn { get; set; }
        public string RewardReasonNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string RewardReasonCode { get; set; }
    }
}
