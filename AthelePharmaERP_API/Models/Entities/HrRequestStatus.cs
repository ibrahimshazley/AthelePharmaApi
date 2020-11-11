using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrRequestStatus
    {
        public string RequestStatusId { get; set; }
        public string RequestStatusName { get; set; }
        public string RequestStatusNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
