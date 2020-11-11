using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrOfficialVacations
    {
        public decimal Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string VacationName { get; set; }
        public string VacationNameEn { get; set; }
        public string VacDate { get; set; }
        public string VacDateHijri { get; set; }
        public string VacDayType { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public byte DeductFromAnnualVac { get; set; }
    }
}
