using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpExperiences
    {
        public Guid DtlsId { get; set; }
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public string ExperienceName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string JobTitle { get; set; }
        public string Place { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Notes { get; set; }
        public string DocAttach { get; set; }
        public string ExperienceCategoryId { get; set; }
        public string ExperienceId { get; set; }
        public string ReferenceType { get; set; }
        public Guid? EmpHdrId { get; set; }

        public virtual HrEmployees HrEmployees { get; set; }
    }
}
