using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class VwEmpRewardRequestWorkFlowHistory
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public Guid? HdrId { get; set; }
        public string EmpComment { get; set; }
        public string FullNameArabic { get; set; }
        public string FullNameEn { get; set; }
        public string JobNameEn { get; set; }
        public string JobName { get; set; }
        public decimal SenderSerialNo { get; set; }
        public decimal RecieverSerialNo { get; set; }
        public string RecieverArabicName { get; set; }
        public string RecieverEnglishName { get; set; }
        public string RecieverImagePath { get; set; }
        public string SenderImagePath { get; set; }
        public byte EmpReplay { get; set; }
        public DateTime? DateReplay { get; set; }
        public string JobId { get; set; }
        public byte WorkFlowOrder { get; set; }
        public DateTime? MaxiumDateReplay { get; set; }
        public string Notes { get; set; }
        public decimal? AlternateEmpSerialNo { get; set; }
        public string AlternateJobId { get; set; }
        public string AlternativeJoibNameEn { get; set; }
        public string AlternativeJoibName { get; set; }
        public string AlternativeEmpName { get; set; }
        public string AlternativeEmpNameEn { get; set; }
    }
}
