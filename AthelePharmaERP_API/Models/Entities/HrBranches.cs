using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBranches
    {
        public HrBranches()
        {
            HrAdministrations = new HashSet<HrAdministrations>();
            HrBranchDocsHdr = new HashSet<HrBranchDocsHdr>();
            HrEmployees = new HashSet<HrEmployees>();
            HrGradeJobGroups = new HashSet<HrGradeJobGroups>();
            HrShiftGroups = new HashSet<HrShiftGroups>();
            HrShifts = new HashSet<HrShifts>();
        }

        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchNameEn { get; set; }
        public string BranchNameConv { get; set; }
        public string BranchAccountNo { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string Prefix { get; set; }
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string CurrencyId { get; set; }
        public string StreetName { get; set; }
        public string BuidingNumber { get; set; }
        public string POBox { get; set; }
        public string PostalCode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ExtenstionTel1 { get; set; }
        public string ExtenstionTel2 { get; set; }
        public string ExtenstionTel3 { get; set; }
        public decimal? ResponsibleEmpId { get; set; }
        public decimal Id { get; set; }

        public virtual HrCompanies Company { get; set; }
        public virtual ICollection<HrAdministrations> HrAdministrations { get; set; }
        public virtual ICollection<HrBranchDocsHdr> HrBranchDocsHdr { get; set; }
        public virtual ICollection<HrEmployees> HrEmployees { get; set; }
        public virtual ICollection<HrGradeJobGroups> HrGradeJobGroups { get; set; }
        public virtual ICollection<HrShiftGroups> HrShiftGroups { get; set; }
        public virtual ICollection<HrShifts> HrShifts { get; set; }
    }
}
