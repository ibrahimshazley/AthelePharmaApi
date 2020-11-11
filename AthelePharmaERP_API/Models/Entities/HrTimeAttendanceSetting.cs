using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrTimeAttendanceSetting
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string MachineNo { get; set; }
        public byte? CheckInCodeFrmFp { get; set; }
        public byte? CheckOutCodeFrmFp { get; set; }
    }
}
