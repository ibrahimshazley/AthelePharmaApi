using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrSocialInsuranceTypes
    {
        public string InsuranceTypeId { get; set; }
        public string InsuranceTypeName { get; set; }
        public string InsuranceTypeNameEn { get; set; }
        public string HireItemId { get; set; }
        public byte? DeductOnEmpOrComp { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
