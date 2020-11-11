using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrSocialInsuranceDeductionPercntgSa
    {
        public decimal RecId { get; set; }
        public string InsuranceTypeId { get; set; }
        public string HireItemId { get; set; }
        public byte? DeductOnEmpOrComp { get; set; }
        public byte? EmpNationalTypeId { get; set; }
        public decimal? DeductPercentage { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
    }
}
