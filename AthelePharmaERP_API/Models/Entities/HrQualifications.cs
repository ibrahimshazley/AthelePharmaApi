using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrQualifications
    {
        public string QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string QualificationNameEn { get; set; }
        public string QualificationNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string QualificationCode { get; set; }
        public decimal Id { get; set; }
    }
}
