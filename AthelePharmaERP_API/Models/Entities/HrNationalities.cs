using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrNationalities
    {
        public string NationalityId { get; set; }
        public string NationalityName { get; set; }
        public string NationalityNameEn { get; set; }
        public string NationalityNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string NationalityCode { get; set; }
        public decimal Id { get; set; }
    }
}
