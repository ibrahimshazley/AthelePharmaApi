using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrCurrencies
    {
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyNameEn { get; set; }
        public string CurrencyNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string CurrencyCode { get; set; }
    }
}
