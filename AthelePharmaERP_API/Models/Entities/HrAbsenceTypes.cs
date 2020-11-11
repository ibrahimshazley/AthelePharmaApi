using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAbsenceTypes
    {
        public byte AbsenceTypeId { get; set; }
        public string AbsenceTypeName { get; set; }
        public string AbsenceTypeNameEn { get; set; }
        public string AbsenceTypeNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
