using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrCities
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string CityNameEn { get; set; }
        public string CityNameConv { get; set; }
        public string CountryId { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string CityCode { get; set; }
        public decimal Id { get; set; }
    }
}
