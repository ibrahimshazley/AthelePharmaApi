using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployeeContractPeriodsHistory
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RowId { get; set; }
        public decimal ContractPeriodId { get; set; }
        public decimal? ContractId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public decimal? NoOfRestVacDays { get; set; }
        public decimal? NoOfRestVacDaysNew { get; set; }
        public Guid? LastTransRecHdrId { get; set; }
        public Guid? LastTransRecHdrIdNew { get; set; }
        public DateTime? Insdate { get; set; }
    }
}
