using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrBanks
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankNameEn { get; set; }
        public string BankNameConv { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Fax { get; set; }
        public string WebSiteUrl { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public string SwiftCode { get; set; }
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Id { get; set; }
        public string BankCode { get; set; }
    }
}
