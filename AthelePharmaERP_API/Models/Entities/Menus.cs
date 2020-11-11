using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class Menus
    {
        public decimal Id { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuNameEn { get; set; }
        public int? ParentId { get; set; }
        public byte IsActive { get; set; }
        public int LevelId { get; set; }
        public string PathUrl { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
