using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrVactionTypes
    {
        public byte VactionTypeId { get; set; }
        public string VactionTypeName { get; set; }
        public string VactionTypeNameEn { get; set; }
        public string VactionTypeNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
