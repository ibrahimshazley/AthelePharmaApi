using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrOverTimeTypes
    {
        public byte OverTimeTypeId { get; set; }
        public string OverTimeTypeName { get; set; }
        public string OverTimeTypeNameEn { get; set; }
        public string OverTimeTypeNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
