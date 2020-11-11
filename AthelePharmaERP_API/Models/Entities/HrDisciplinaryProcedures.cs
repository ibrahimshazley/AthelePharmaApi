using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrDisciplinaryProcedures
    {
        public string DisciplinaryProcedureId { get; set; }
        public string DisciplinaryProcedureName { get; set; }
        public string DisciplinaryProcedureNameEn { get; set; }
        public string DisciplinaryProcedureNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public byte? DiscountType { get; set; }
        public decimal Id { get; set; }
        public string DisciplinaryProcedureCode { get; set; }
    }
}
