using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBeginEmpReceivableDuesDtls
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string MonthNo { get; set; }
        public string TransDate { get; set; }
        public Guid HdrId { get; set; }
        public string HireItemId { get; set; }
        public decimal HireItemValue { get; set; }
        public string TransItemDate { get; set; }
        public string DueDate { get; set; }
        public string InsItemUser { get; set; }
        public DateTime? InsItemDate { get; set; }
        public Guid? RecRequestHdrId { get; set; }
    }
}
