using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpOtherMonthlyValueRecord
    {
        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public string MonthNo { get; set; }
        public string Notes { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public decimal? MonthlyValue { get; set; }
        public string HireItemId { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
