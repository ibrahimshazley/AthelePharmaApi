using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrGrades
    {
        public string GradeId { get; set; }
        public string GradeName { get; set; }
        public string GradeNameEn { get; set; }
        public string GradeNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string GradeCode { get; set; }
        public decimal Id { get; set; }
    }
}
