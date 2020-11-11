using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrHiringItems
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string HireItemId { get; set; }
        public string HireItemName { get; set; }
        public string HireItemNameEn { get; set; }
        public string HireItemNameConv { get; set; }
        public byte HireItemType { get; set; }
        public byte AccountType { get; set; }
        public byte HireAppearWGrade { get; set; }
        public byte HireStatus { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public byte? JoinEndOfService { get; set; }
        public byte? CalcAnnually { get; set; }
        public byte? NotIncludeVacAllownce { get; set; }
        public byte? AffectsSalaries { get; set; }
        public byte HireAppearOnlyWGrades { get; set; }
        public byte? IsPaymentBorrow { get; set; }
    }
}
