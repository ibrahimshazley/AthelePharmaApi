using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpBeginAnnualVacTransferdBal
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public string Transdate { get; set; }
        public decimal EmpSerialNo { get; set; }
        public decimal? TotBalByDays { get; set; }
        public DateTime? Insdate { get; set; }
        public string InsUser { get; set; }
    }
}
