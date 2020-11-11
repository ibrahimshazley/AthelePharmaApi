using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDues
    {
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string GradeJobId { get; set; }
        public string GradeId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string HireItemId { get; set; }
        public decimal HireItemValue { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? EmpHdrId { get; set; }
        public byte RecStatus { get; set; }
        public string RowState { get; set; }
    }
}
