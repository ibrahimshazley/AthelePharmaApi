using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrCompanies
    {
        public HrCompanies()
        {
            HrBranches = new HashSet<HrBranches>();
            HrEmployees = new HashSet<HrEmployees>();
            HrShifts = new HashSet<HrShifts>();
        }

        public string CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameEn { get; set; }
        public string CompanyNameConv { get; set; }
        public string CompanyAccountNo { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public string FieldAr { get; set; }
        public string FieldEn { get; set; }
        public string LogoPath { get; set; }
        public decimal? ResponsibleEmpId { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<HrBranches> HrBranches { get; set; }
        public virtual ICollection<HrEmployees> HrEmployees { get; set; }
        public virtual ICollection<HrShifts> HrShifts { get; set; }
    }
}
