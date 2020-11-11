using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrJobs
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string JobId { get; set; }
        public string JobCode { get; set; }
        public string JobName { get; set; }
        public string JobNameEn { get; set; }
        public string JobNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public byte IsManager { get; set; }
        public string GradeJobId { get; set; }
        public decimal Id { get; set; }
    }
}
