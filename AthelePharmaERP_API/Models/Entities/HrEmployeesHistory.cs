using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrEmployeesHistory
    {
        public decimal RecId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public decimal? EmpSerialNo { get; set; }
        public string EmpId { get; set; }
        public string EmpCode { get; set; }
        public string ProjectId { get; set; }
        public string ProjectIdNew { get; set; }
        public string ContractId { get; set; }
        public string ContractIdNew { get; set; }
        public string AdminId { get; set; }
        public string AdminIdNew { get; set; }
        public string DeptId { get; set; }
        public string DeptIdNew { get; set; }
        public string JobId { get; set; }
        public string JobIdNew { get; set; }
        public string GradeId { get; set; }
        public string GradeIdNew { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleNew { get; set; }
        public string GradeJobId { get; set; }
        public string GradeJobIdNew { get; set; }
        public string QualifyTypeId { get; set; }
        public string QualifyTypeIdNew { get; set; }
        public string QualifyId { get; set; }
        public string QualifyIdNew { get; set; }
        public string ShiftId { get; set; }
        public string ShiftIdNew { get; set; }
        public string ManagerId { get; set; }
        public string ManagerIdNew { get; set; }
        public decimal? CommissionerSerialNo { get; set; }
        public decimal? CommissionerSerialNoNew { get; set; }
        public string InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string InsTransUser { get; set; }
        public DateTime? InsTransDate { get; set; }
        public Guid? EmpHdrId { get; set; }
        public string Transdate { get; set; }
        public byte? RecStatus { get; set; }
        public byte? RecStatusNew { get; set; }
        public string EmpStatusId { get; set; }
        public string EmpStatusIdNew { get; set; }
        public string ContractClassify { get; set; }
        public string ContractClassifyNew { get; set; }
        public string StartContract { get; set; }
        public string StartContractNew { get; set; }
        public string EndContract { get; set; }
        public string EndContractNew { get; set; }
        public decimal? ContractPeriodByMonth { get; set; }
        public decimal? ContractPeriodByMonthNew { get; set; }
    }
}
