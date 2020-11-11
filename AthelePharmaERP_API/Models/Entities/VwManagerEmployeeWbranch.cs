using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class VwManagerEmployeeWbranch
    {
        public decimal EmpSerialNo { get; set; }
        public string EmpId { get; set; }
        public string EmpCode { get; set; }
        public string FullNameArabic { get; set; }
        public string FullNameEn { get; set; }
        public byte IsManager { get; set; }
        public byte RecStatus { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
