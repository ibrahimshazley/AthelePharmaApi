using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrProjects
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNameEn { get; set; }
        public string ProjectNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string ProjectCode { get; set; }
        public decimal Id { get; set; }
    }
}
