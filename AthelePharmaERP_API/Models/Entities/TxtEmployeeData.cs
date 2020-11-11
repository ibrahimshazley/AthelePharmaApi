using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class TxtEmployeeData
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string IdentityId { get; set; }
        public string FinishDateAm { get; set; }
        public string FinishDateHijri { get; set; }
        public string Job { get; set; }
        public string Status { get; set; }
        public string Year { get; set; }
        public string VacationDays { get; set; }
        public decimal Id { get; set; }
    }
}
