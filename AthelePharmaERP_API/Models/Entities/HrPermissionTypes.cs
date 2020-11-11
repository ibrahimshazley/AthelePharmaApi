using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrPermissionTypes
    {
        public byte PermissionTypeId { get; set; }
        public string PermissionTypeName { get; set; }
        public string PermissionTypeNameEn { get; set; }
        public string PermissionTypeNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
    }
}
