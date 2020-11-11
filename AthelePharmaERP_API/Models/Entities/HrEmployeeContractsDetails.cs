using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployeeContractsDetails
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal ContractId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string StartContract { get; set; }
        public string EndContract { get; set; }
        public decimal? ContractPeriodByMonth { get; set; }
        public string WorkStartingDate { get; set; }
    }
}
