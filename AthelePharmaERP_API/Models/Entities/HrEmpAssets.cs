using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmpAssets
    {
        public Guid HdrId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal EmpSerialNo { get; set; }
        public decimal RecieptNo { get; set; }
        public string Transdate { get; set; }
        public decimal AssetGroupId { get; set; }
        public decimal AssetValue { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual HrAssetsGroup HrAssetsGroup { get; set; }
        public virtual HrEmployees HrEmployees { get; set; }
    }
}
