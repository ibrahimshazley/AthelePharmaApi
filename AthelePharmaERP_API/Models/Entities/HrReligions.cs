using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrReligions
    {
        public string ReligionId { get; set; }
        public string ReligionName { get; set; }
        public string ReligionNameEn { get; set; }
        public string ReligionNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string ReligionCode { get; set; }
        public decimal Id { get; set; }
    }
}
