using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrGradeJobGroups
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string GradeJobId { get; set; }
        public string GradeJobCode { get; set; }
        public string GradeJobName { get; set; }
        public string GradeJobNameEn { get; set; }
        public string GradeJobNameConv { get; set; }
        public string GradeJobAccountNo { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public decimal Id { get; set; }

        public virtual HrBranches HrBranches { get; set; }
    }
}
