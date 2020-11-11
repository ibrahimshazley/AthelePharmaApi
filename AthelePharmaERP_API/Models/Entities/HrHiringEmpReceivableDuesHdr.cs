using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringEmpReceivableDuesHdr
    {
        public HrHiringEmpReceivableDuesHdr()
        {
            HrHiringEmpReceivableDuesDtls = new HashSet<HrHiringEmpReceivableDuesDtls>();
        }

        public Guid HdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string MonthNo { get; set; }
        public string TransDate { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte EmpRecStatus { get; set; }
        public byte EmpStatus { get; set; }

        public virtual ICollection<HrHiringEmpReceivableDuesDtls> HrHiringEmpReceivableDuesDtls { get; set; }
    }
}
