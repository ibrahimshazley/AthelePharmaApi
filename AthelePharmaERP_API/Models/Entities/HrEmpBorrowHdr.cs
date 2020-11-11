using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpBorrowHdr
    {
        public HrEmpBorrowHdr()
        {
            HrEmpBorrowDtls = new HashSet<HrEmpBorrowDtls>();
        }

        public Guid HdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal RecNo { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string Transdate { get; set; }
        public string RecOrderNo { get; set; }
        public Guid? RecOrderHdrId { get; set; }
        public string RequestId { get; set; }
        public decimal BorrowValue { get; set; }
        public decimal BorrowPeriod { get; set; }
        public string BorrowStartDate { get; set; }
        public decimal? BorrowMonthValue { get; set; }
        public byte BorrowStatus { get; set; }
        public string Notes { get; set; }
        public string HireItemId { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string BorrowDuesDate { get; set; }
        public string MessageNotesForEmp { get; set; }
        public decimal? ContractId { get; set; }
        public decimal? ContractPeriodId { get; set; }

        public virtual ICollection<HrEmpBorrowDtls> HrEmpBorrowDtls { get; set; }
    }
}
