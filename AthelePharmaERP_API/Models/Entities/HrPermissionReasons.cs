using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrPermissionReasons
    {
        public string PermissionReasonId { get; set; }
        public string PermissionReasonName { get; set; }
        public string PermissionReasonNameEn { get; set; }
        public string PermissionReasonNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string PermissionReasonCode { get; set; }
        public string PermissionType { get; set; }
    }
}
