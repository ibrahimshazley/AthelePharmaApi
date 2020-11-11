using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpAccomdationFeesHdr
    {
        public Guid HdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string Transdate { get; set; }
        public string RecOrderNo { get; set; }
        public Guid? RecOrderHdrId { get; set; }
        public decimal AccomdtionFeeValue { get; set; }
        public decimal AccomdtionFeePeriod { get; set; }
        public string AccomdtionFeeStartDate { get; set; }
        public decimal? AccomdtionFeeMonthValue { get; set; }
        public byte AccomdtionFeeStatus { get; set; }
        public string Notes { get; set; }
        public string HireItemId { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string AccomdtionFeeDuesDate { get; set; }
        public string MessageNotesForEmp { get; set; }
        public decimal? ContractId { get; set; }
        public decimal? ContractPeriodId { get; set; }
        public decimal? TotalAllaccomdationValue { get; set; }
        public decimal? CompanyFeesValue { get; set; }
    }
}
