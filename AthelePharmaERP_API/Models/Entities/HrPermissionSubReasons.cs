using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrPermissionSubReasons
    {
        public string PermissionSubReasonId { get; set; }
        public string PermissionSubReasonName { get; set; }
        public string PermissionSubReasonNameEn { get; set; }
        public string PermissionSubReasonNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string PermissionSubReasonCode { get; set; }
        public string PermissionReasonId { get; set; }
        public string PermissionType { get; set; }
    }
}
