using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpAttendanceHdr
    {
        public HrEmpAttendanceHdr()
        {
            HrEmpAttendanceDtls = new HashSet<HrEmpAttendanceDtls>();
        }

        public Guid RecHdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string Transdate { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string MonthNo { get; set; }
        public decimal? DailyWorkingPeriodInMinute { get; set; }

        public virtual ICollection<HrEmpAttendanceDtls> HrEmpAttendanceDtls { get; set; }
    }
}
