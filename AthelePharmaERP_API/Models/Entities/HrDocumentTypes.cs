using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrDocumentTypes
    {
        public HrDocumentTypes()
        {
            HrBranchDocsHdr = new HashSet<HrBranchDocsHdr>();
            HrEmpDocsHdr = new HashSet<HrEmpDocsHdr>();
        }

        public string DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public string DocTypeNameEn { get; set; }
        public string DocTypeNameConv { get; set; }
        public string DocType { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string DocTypeCode { get; set; }

        public virtual ICollection<HrBranchDocsHdr> HrBranchDocsHdr { get; set; }
        public virtual ICollection<HrEmpDocsHdr> HrEmpDocsHdr { get; set; }
    }
}
