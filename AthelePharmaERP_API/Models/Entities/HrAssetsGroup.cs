using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrAssetsGroup
    {
        public HrAssetsGroup()
        {
            HrEmpAssets = new HashSet<HrEmpAssets>();
        }

        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal AssetGroupId { get; set; }
        public string AssetName { get; set; }
        public string AssetNameEn { get; set; }
        public string AssetNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }

        public virtual ICollection<HrEmpAssets> HrEmpAssets { get; set; }
    }
}
