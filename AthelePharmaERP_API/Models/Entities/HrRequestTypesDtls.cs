using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrRequestTypesDtls
    {
        public decimal DtlsId { get; set; }
        public string RequestTypeId { get; set; }
        public decimal RequestTypeValue { get; set; }
        public string RequestDiscountType { get; set; }
        public decimal RequestRatioValue { get; set; }
        public string ValueType { get; set; }
    }
}
