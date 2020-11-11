using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthelePharmaERP_API.Models.DTOs
{
    public class PermissionRequestDTO
    {
        public Guid RecHdrId { get; set; }
        public decimal RecNo { get; set; }
        public string ReferenceNo { get; set; }
        public string RequestId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public string PermissionDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string OrderStatus { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string MessageNotesForEmp { get; set; }
        public decimal? ContractId { get; set; }
        public decimal? ContractPeriodId { get; set; }
        public string PermissionType { get; set; }
         public string PermissionReasonId { get; set; }
        public string PermissionReasonSubId { get; set; }

    }
}
