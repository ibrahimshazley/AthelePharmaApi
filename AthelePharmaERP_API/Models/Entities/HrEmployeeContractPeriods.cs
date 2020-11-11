using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployeeContractPeriods
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal ContractPeriodId { get; set; }
        public decimal? ContractId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string WorkStartingDate { get; set; }
        public string FromStartPeriod { get; set; }
        public string ToEndPeriod { get; set; }
        public decimal? NoOfDeservedDays { get; set; }
        public decimal? NoOfVacDays { get; set; }
        public decimal? NoOfRestVacDays { get; set; }
        public Guid? LastTransRecHdrId { get; set; }
        public DateTime? Insdate { get; set; }
    }
}
