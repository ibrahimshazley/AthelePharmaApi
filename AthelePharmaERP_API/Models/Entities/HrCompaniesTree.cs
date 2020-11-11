using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrCompaniesTree
    {
        public decimal RecSerialId { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNameEn { get; set; }
        public string AccountNameConv { get; set; }
        public byte AccountTreeType { get; set; }
        public string AccountParentId { get; set; }
        public byte HasLastLeaf { get; set; }
        public byte HasLeaf { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
