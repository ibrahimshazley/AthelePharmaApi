using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class Groups
    {
        public decimal GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupNameEn { get; set; }
        public byte? Status { get; set; }
        public string UserRole { get; set; }
        public string Description { get; set; }
    }
}
