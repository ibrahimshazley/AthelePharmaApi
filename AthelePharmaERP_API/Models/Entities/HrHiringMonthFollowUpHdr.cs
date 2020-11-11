using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringMonthFollowUpHdr
    {
        public HrHiringMonthFollowUpHdr()
        {
            HrHiringMonthFollowUpDtls = new HashSet<HrHiringMonthFollowUpDtls>();
        }

        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string MonthNo { get; set; }
        public string TransDate { get; set; }
        public byte SalMonthStatus { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte DeliveredComplete { get; set; }
        public byte EmpRecStatus { get; set; }
        public byte EmpStatus { get; set; }

        public virtual ICollection<HrHiringMonthFollowUpDtls> HrHiringMonthFollowUpDtls { get; set; }
    }
}
