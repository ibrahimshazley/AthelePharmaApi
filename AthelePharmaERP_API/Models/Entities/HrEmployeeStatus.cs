using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployeeStatus
    {
        public string EmployeeStatusId { get; set; }
        public string EmployeeStatusName { get; set; }
        public string EmployeeStatusNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
