using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrRequestGroupTypes
    {
        public string RequestGroupTypeId { get; set; }
        public string RequestGroupTypeName { get; set; }
        public string RequestGroupTypeNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
