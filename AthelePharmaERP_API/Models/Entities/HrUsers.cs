using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrUsers
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal EmpSerialNo { get; set; }
        public DateTime? LastUpdatePassDate { get; set; }
        public decimal? FailedCount { get; set; }
        public string UserAdmin { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
