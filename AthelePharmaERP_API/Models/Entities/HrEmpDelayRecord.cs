using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDelayRecord
    {
        public Guid RecHdrId { get; set; }
        public decimal RecNo { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public decimal DelayPeriod { get; set; }
        public string Notes { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string HireItemId { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
