using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrRequestTypes
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string RequestId { get; set; }
        public string RequestName { get; set; }
        public string RequestNameEn { get; set; }
        public string RequestNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public byte? RequestType { get; set; }
        public byte AttachIsNecessary { get; set; }
        public byte VactionIndivisible { get; set; }
        public byte SendOnlyToManger { get; set; }
        public byte? ChkJoinHireItem { get; set; }
        public string HireItemId { get; set; }
    }
}
