using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranchDocuments
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string DocId { get; set; }
        public string DocName { get; set; }
        public string DocNameEn { get; set; }
        public string DocNameConv { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string IssuePlace { get; set; }
        public string IssueRegion { get; set; }
        public string Notes { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
