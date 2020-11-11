using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpCertifications
    {
        public Guid DtlsId { get; set; }
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string CertificationName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string MajorName { get; set; }
        public string Degree { get; set; }
        public string Place { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CertificationNo { get; set; }
        public string DocAttach { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string Notes { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
