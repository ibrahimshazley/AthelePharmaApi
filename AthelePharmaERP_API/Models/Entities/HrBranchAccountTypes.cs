using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranchAccountTypes
    {
        public string BranchAccountTypeId { get; set; }
        public string BranchAccountTypeName { get; set; }
        public string BranchAccountTypeNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
