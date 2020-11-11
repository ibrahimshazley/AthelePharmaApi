using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrTicketTypes
    {
        public string TicketTypeId { get; set; }
        public string TicketTypeName { get; set; }
        public string TicketTypeNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
