using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDuesVactionTicketHistory
    {
        public decimal DtlsId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string GradeJobId { get; set; }
        public string GradeJobIdNew { get; set; }
        public decimal? VactionPeriod { get; set; }
        public decimal? VactionPeriodNew { get; set; }
        public string VactionTicketType { get; set; }
        public string VactionTicketTypeNew { get; set; }
        public string InternationalWorkTicketType { get; set; }
        public string InternationalWorkTicketTypeNew { get; set; }
        public string LocalWorkTicketType { get; set; }
        public string LocalWorkTicketTypeNew { get; set; }
        public string TransDate { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string InsTransUser { get; set; }
        public DateTime? InsTransDate { get; set; }
        public decimal? DtlsIdOrg { get; set; }
        public byte? RecStatus { get; set; }
        public decimal? WorkingMonthNo { get; set; }
        public string WorkingPeriodType { get; set; }
        public decimal? WorkingMonthNoNew { get; set; }
        public string WorkingPeriodTypeNew { get; set; }
    }
}
