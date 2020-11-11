using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpVactionRecord
    {
        public Guid RecHdrId { get; set; }
        public decimal RecNo { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public Guid? RecOrderHdrId { get; set; }
        public string RecOrderNo { get; set; }
        public string RequestId { get; set; }
        public string TransDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string BackDate { get; set; }
        public decimal VactionPeriod { get; set; }
        public string PlaceOfResidence { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string MessageNotesForEmp { get; set; }
        public string HireItemId { get; set; }
        public decimal? FreeBalancRequest { get; set; }
        public decimal? ChargeBalancRequest { get; set; }
        public string AcuallBackDate { get; set; }
        public decimal? AcuallVactionPeiod { get; set; }
        public decimal? ContractId { get; set; }
        public decimal? ContractPeriodId { get; set; }
        public decimal? TotTransferdPeriod { get; set; }
        public decimal? CurrDiscVacPeriod { get; set; }
        public decimal? CurrDiscTransferdPeriod { get; set; }
        public decimal? PrevVactionPeriod { get; set; }
        public decimal? CurrAllowedVacTillDate { get; set; }
        public string VacPlaceType { get; set; }
        public decimal? OfficalVactionPeriod { get; set; }
        public decimal? VactionFromPrmEffec { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
