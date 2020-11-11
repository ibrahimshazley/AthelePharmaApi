using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpTravelTickectRequest
    {
        public Guid RecHdrId { get; set; }
        public decimal RecNo { get; set; }
        public string ReferenceNo { get; set; }
        public string RequestId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string TransDate { get; set; }
        public string GoDate { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string OrderStatus { get; set; }
        public string DocumentPath { get; set; }
        public decimal CommissionerSerialNo { get; set; }
        public string ReturnDate { get; set; }
        public string GoAmPm { get; set; }
        public string ReturnAmPm { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AirPortCompany { get; set; }
        public string Notes { get; set; }
        public string ReserverdType { get; set; }
        public decimal? ReserverdValue { get; set; }
        public decimal? ActuallValue { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
