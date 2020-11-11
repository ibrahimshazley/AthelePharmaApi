using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrDeductionReasons
    {
        public string DeductionReasonId { get; set; }
        public string DeductionReasonName { get; set; }
        public string DeductionReasonNameEn { get; set; }
        public string DeductionReasonNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string DeductionReasonCode { get; set; }
    }
}
