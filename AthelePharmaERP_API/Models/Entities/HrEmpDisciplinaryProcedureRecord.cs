using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDisciplinaryProcedureRecord
    {
        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public string RequestId { get; set; }
        public string RecOrderNo { get; set; }
        public Guid? RecOrderHdrId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public string Notes { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string DisciplinaryProcedureId { get; set; }
        public decimal? DiscountValue { get; set; }
        public string DiscountApplyDate { get; set; }
        public byte? DiscountType { get; set; }
        public string HireItemId { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
