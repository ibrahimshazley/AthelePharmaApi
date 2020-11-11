using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranchAccounts
    {
        public Guid DtlHdrId { get; set; }
        public decimal RecId { get; set; }
        public string BranchId { get; set; }
        public string CompanyId { get; set; }
        public string BankId { get; set; }
        public string AccountType { get; set; }
        public string BrnchAccountNo { get; set; }
        public byte RecStatus { get; set; }
        public string RowState { get; set; }
    }
}
