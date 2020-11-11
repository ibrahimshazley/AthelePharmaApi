using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmploymentQualifyRecord
    {
        public Guid DtlsId { get; set; }
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string QualificationId { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public Guid? RecHdrId { get; set; }
        public string Notes { get; set; }
        public int? RowId { get; set; }
    }
}
