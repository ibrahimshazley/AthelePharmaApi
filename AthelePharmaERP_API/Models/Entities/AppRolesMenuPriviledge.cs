using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class AppRolesMenuPriviledge
    {
        public string RoleId { get; set; }
        public string MenuId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public byte IsVisiable { get; set; }
        public byte CanInsert { get; set; }
        public byte CanUpdate { get; set; }
        public byte CanDelete { get; set; }
        public byte CanSearch { get; set; }
    }
}
