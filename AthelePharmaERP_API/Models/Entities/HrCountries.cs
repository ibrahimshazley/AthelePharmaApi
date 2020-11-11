using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrCountries
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryNameEn { get; set; }
        public string CountryNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string CountryCode { get; set; }
        public decimal Id { get; set; }
    }
}
