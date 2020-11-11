using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpDuesVactionTicket
    {
        public decimal DtlsId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string GradeJobId { get; set; }
        public decimal VactionPeriod { get; set; }
        public string VactionTicketType { get; set; }
        public string InternationalWorkTicketType { get; set; }
        public string LocalWorkTicketType { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? RecStatus { get; set; }
        public decimal? WorkingMonthNo { get; set; }
        public string WorkingPeriodType { get; set; }
    }
}
