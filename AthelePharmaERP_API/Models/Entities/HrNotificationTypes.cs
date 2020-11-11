using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrNotificationTypes
    {
        public string NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; }
        public string NotificationTypeNameEn { get; set; }
        public byte RecStatus { get; set; }
    }
}
