using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAppSettingTypes
    {
        public string AppSettingTypeId { get; set; }
        public string AppSettingTypeName { get; set; }
        public string AppSettingTypeNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
