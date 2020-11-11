using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class PharmaERPTestContext : DbContext
    {
        public PharmaERPTestContext()
        {
        }

        public PharmaERPTestContext(DbContextOptions<PharmaERPTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppDuesAndDeductSetting> AppDuesAndDeductSetting { get; set; }
        public virtual DbSet<AppErrorLog> AppErrorLog { get; set; }
        public virtual DbSet<AppMenus> AppMenus { get; set; }
        public virtual DbSet<AppRolesMenuPriviledge> AppRolesMenuPriviledge { get; set; }
        public virtual DbSet<AppSettings> AppSettings { get; set; }
        public virtual DbSet<AppUsersMenuPriviledge> AppUsersMenuPriviledge { get; set; }
        public virtual DbSet<ArDict> ArDict { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<GroupPages> GroupPages { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<HrAbsenceTypes> HrAbsenceTypes { get; set; }
        public virtual DbSet<HrAdministrations> HrAdministrations { get; set; }
        public virtual DbSet<HrAlternativeEmployeesTrans> HrAlternativeEmployeesTrans { get; set; }
        public virtual DbSet<HrAppSettingTypes> HrAppSettingTypes { get; set; }
        public virtual DbSet<HrAssetsGroup> HrAssetsGroup { get; set; }
        public virtual DbSet<HrAssignWorkFlowToRequest> HrAssignWorkFlowToRequest { get; set; }
        public virtual DbSet<HrBanks> HrBanks { get; set; }
        public virtual DbSet<HrBeginEmpReceivableDuesDtls> HrBeginEmpReceivableDuesDtls { get; set; }
        public virtual DbSet<HrBranchAccountTypes> HrBranchAccountTypes { get; set; }
        public virtual DbSet<HrBranchAccounts> HrBranchAccounts { get; set; }
        public virtual DbSet<HrBranchDocNotificationDtls> HrBranchDocNotificationDtls { get; set; }
        public virtual DbSet<HrBranchDocsDtlsHistory> HrBranchDocsDtlsHistory { get; set; }
        public virtual DbSet<HrBranchDocsHdr> HrBranchDocsHdr { get; set; }
        public virtual DbSet<HrBranchDocuments> HrBranchDocuments { get; set; }
        public virtual DbSet<HrBranches> HrBranches { get; set; }
        public virtual DbSet<HrCities> HrCities { get; set; }
        public virtual DbSet<HrCompanies> HrCompanies { get; set; }
        public virtual DbSet<HrCompaniesTree> HrCompaniesTree { get; set; }
        public virtual DbSet<HrCountries> HrCountries { get; set; }
        public virtual DbSet<HrCurrencies> HrCurrencies { get; set; }
        public virtual DbSet<HrDailyTimeSheet> HrDailyTimeSheet { get; set; }
        public virtual DbSet<HrDayTypes> HrDayTypes { get; set; }
        public virtual DbSet<HrDeductionReasons> HrDeductionReasons { get; set; }
        public virtual DbSet<HrDepartments> HrDepartments { get; set; }
        public virtual DbSet<HrDisciplinaryProcedures> HrDisciplinaryProcedures { get; set; }
        public virtual DbSet<HrDismissalReasons> HrDismissalReasons { get; set; }
        public virtual DbSet<HrDocumentTypes> HrDocumentTypes { get; set; }
        public virtual DbSet<HrEmpAbsenceRecord> HrEmpAbsenceRecord { get; set; }
        public virtual DbSet<HrEmpAccomdationFeesDtls> HrEmpAccomdationFeesDtls { get; set; }
        public virtual DbSet<HrEmpAccomdationFeesHdr> HrEmpAccomdationFeesHdr { get; set; }
        public virtual DbSet<HrEmpAccomdationFeesOrgDtls> HrEmpAccomdationFeesOrgDtls { get; set; }
        public virtual DbSet<HrEmpAccomdationFeesOrgHdr> HrEmpAccomdationFeesOrgHdr { get; set; }
        public virtual DbSet<HrEmpAccomdationFeesSetting> HrEmpAccomdationFeesSetting { get; set; }
        public virtual DbSet<HrEmpAnnualLeavePlanRecord> HrEmpAnnualLeavePlanRecord { get; set; }
        public virtual DbSet<HrEmpAnnualLeavePlanRequest> HrEmpAnnualLeavePlanRequest { get; set; }
        public virtual DbSet<HrEmpAnnualLeavePlanRequestWorkFlow> HrEmpAnnualLeavePlanRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpAssets> HrEmpAssets { get; set; }
        public virtual DbSet<HrEmpAttendanceDtls> HrEmpAttendanceDtls { get; set; }
        public virtual DbSet<HrEmpAttendanceHdr> HrEmpAttendanceHdr { get; set; }
        public virtual DbSet<HrEmpBeginAnnualVacTransferdBal> HrEmpBeginAnnualVacTransferdBal { get; set; }
        public virtual DbSet<HrEmpBorrowDelayRecord> HrEmpBorrowDelayRecord { get; set; }
        public virtual DbSet<HrEmpBorrowDelayRequest> HrEmpBorrowDelayRequest { get; set; }
        public virtual DbSet<HrEmpBorrowDelayRequestWorkFlow> HrEmpBorrowDelayRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpBorrowDtls> HrEmpBorrowDtls { get; set; }
        public virtual DbSet<HrEmpBorrowHdr> HrEmpBorrowHdr { get; set; }
        public virtual DbSet<HrEmpBorrowRequest> HrEmpBorrowRequest { get; set; }
        public virtual DbSet<HrEmpBorrowRequestWorkFlow> HrEmpBorrowRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpBorrowSettings> HrEmpBorrowSettings { get; set; }
        public virtual DbSet<HrEmpCertifications> HrEmpCertifications { get; set; }
        public virtual DbSet<HrEmpContractFinishNotifictions> HrEmpContractFinishNotifictions { get; set; }
        public virtual DbSet<HrEmpContracts> HrEmpContracts { get; set; }
        public virtual DbSet<HrEmpDelayRecord> HrEmpDelayRecord { get; set; }
        public virtual DbSet<HrEmpDisciplinaryProcedureRecord> HrEmpDisciplinaryProcedureRecord { get; set; }
        public virtual DbSet<HrEmpDisciplinaryProcedureRequest> HrEmpDisciplinaryProcedureRequest { get; set; }
        public virtual DbSet<HrEmpDisciplinaryProcedureRequestWorkFlow> HrEmpDisciplinaryProcedureRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpDismissalRecord> HrEmpDismissalRecord { get; set; }
        public virtual DbSet<HrEmpDismissalRequest> HrEmpDismissalRequest { get; set; }
        public virtual DbSet<HrEmpDismissalRequestWorkFlow> HrEmpDismissalRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpDocNotificationDtls> HrEmpDocNotificationDtls { get; set; }
        public virtual DbSet<HrEmpDocsDtlsHistory> HrEmpDocsDtlsHistory { get; set; }
        public virtual DbSet<HrEmpDocsHdr> HrEmpDocsHdr { get; set; }
        public virtual DbSet<HrEmpDues> HrEmpDues { get; set; }
        public virtual DbSet<HrEmpDuesHistory> HrEmpDuesHistory { get; set; }
        public virtual DbSet<HrEmpDuesVactionTicket> HrEmpDuesVactionTicket { get; set; }
        public virtual DbSet<HrEmpDuesVactionTicketHistory> HrEmpDuesVactionTicketHistory { get; set; }
        public virtual DbSet<HrEmpEmploymentRecord> HrEmpEmploymentRecord { get; set; }
        public virtual DbSet<HrEmpEmploymentRequest> HrEmpEmploymentRequest { get; set; }
        public virtual DbSet<HrEmpEmploymentRequestWorkFlow> HrEmpEmploymentRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpExperiences> HrEmpExperiences { get; set; }
        public virtual DbSet<HrEmpExtraRecord> HrEmpExtraRecord { get; set; }
        public virtual DbSet<HrEmpHiringMonthStatus> HrEmpHiringMonthStatus { get; set; }
        public virtual DbSet<HrEmpJobMissionRecord> HrEmpJobMissionRecord { get; set; }
        public virtual DbSet<HrEmpJobMissionRequest> HrEmpJobMissionRequest { get; set; }
        public virtual DbSet<HrEmpJobMissionRequestWorkFlow> HrEmpJobMissionRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpOtherMonthlyValueRecord> HrEmpOtherMonthlyValueRecord { get; set; }
        public virtual DbSet<HrEmpOverTimeOrder> HrEmpOverTimeOrder { get; set; }
        public virtual DbSet<HrEmpOverTimeOrderHistory> HrEmpOverTimeOrderHistory { get; set; }
        public virtual DbSet<HrEmpOverTimeRecord> HrEmpOverTimeRecord { get; set; }
        public virtual DbSet<HrEmpOverTimeRequest> HrEmpOverTimeRequest { get; set; }
        public virtual DbSet<HrEmpOverTimeRequestWorkFlow> HrEmpOverTimeRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpOverTimeSettings> HrEmpOverTimeSettings { get; set; }
        public virtual DbSet<HrEmpPermissionOrder> HrEmpPermissionOrder { get; set; }
        public virtual DbSet<HrEmpPermissionOrderHistory> HrEmpPermissionOrderHistory { get; set; }
        public virtual DbSet<HrEmpPermissionRecord> HrEmpPermissionRecord { get; set; }
        public virtual DbSet<HrEmpPermissionRequest> HrEmpPermissionRequest { get; set; }
        public virtual DbSet<HrEmpPermissionRequestWorkFlow> HrEmpPermissionRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpPermissionSettings> HrEmpPermissionSettings { get; set; }
        public virtual DbSet<HrEmpQualifications> HrEmpQualifications { get; set; }
        public virtual DbSet<HrEmpRequestNotify> HrEmpRequestNotify { get; set; }
        public virtual DbSet<HrEmpResignationRecord> HrEmpResignationRecord { get; set; }
        public virtual DbSet<HrEmpResignationRequest> HrEmpResignationRequest { get; set; }
        public virtual DbSet<HrEmpResignationRequestWorkFlow> HrEmpResignationRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpRewardRecord> HrEmpRewardRecord { get; set; }
        public virtual DbSet<HrEmpRewardRequest> HrEmpRewardRequest { get; set; }
        public virtual DbSet<HrEmpRewardRequestWorkFlow> HrEmpRewardRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpSecondmentRecord> HrEmpSecondmentRecord { get; set; }
        public virtual DbSet<HrEmpSecondmentRequest> HrEmpSecondmentRequest { get; set; }
        public virtual DbSet<HrEmpSecondmentRequestWorkFlow> HrEmpSecondmentRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpSecondmentSetting> HrEmpSecondmentSetting { get; set; }
        public virtual DbSet<HrEmpSkills> HrEmpSkills { get; set; }
        public virtual DbSet<HrEmpSons> HrEmpSons { get; set; }
        public virtual DbSet<HrEmpSpouses> HrEmpSpouses { get; set; }
        public virtual DbSet<HrEmpTransferEmployeeRecord> HrEmpTransferEmployeeRecord { get; set; }
        public virtual DbSet<HrEmpTransferEmployeeRequest> HrEmpTransferEmployeeRequest { get; set; }
        public virtual DbSet<HrEmpTransferEmployeeRequestWorkFlow> HrEmpTransferEmployeeRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpTravelTickectRecord> HrEmpTravelTickectRecord { get; set; }
        public virtual DbSet<HrEmpTravelTickectRequest> HrEmpTravelTickectRequest { get; set; }
        public virtual DbSet<HrEmpTravelTickectRequestWorkFlow> HrEmpTravelTickectRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpVactionOrder> HrEmpVactionOrder { get; set; }
        public virtual DbSet<HrEmpVactionOrderHistory> HrEmpVactionOrderHistory { get; set; }
        public virtual DbSet<HrEmpVactionRecord> HrEmpVactionRecord { get; set; }
        public virtual DbSet<HrEmpVactionRequest> HrEmpVactionRequest { get; set; }
        public virtual DbSet<HrEmpVactionRequestWorkFlow> HrEmpVactionRequestWorkFlow { get; set; }
        public virtual DbSet<HrEmpWeekDaysDtls> HrEmpWeekDaysDtls { get; set; }
        public virtual DbSet<HrEmployeeContractPeriods> HrEmployeeContractPeriods { get; set; }
        public virtual DbSet<HrEmployeeContractPeriodsHistory> HrEmployeeContractPeriodsHistory { get; set; }
        public virtual DbSet<HrEmployeeContractsDetails> HrEmployeeContractsDetails { get; set; }
        public virtual DbSet<HrEmployeeStatus> HrEmployeeStatus { get; set; }
        public virtual DbSet<HrEmployees> HrEmployees { get; set; }
        public virtual DbSet<HrEmployeesHistory> HrEmployeesHistory { get; set; }
        public virtual DbSet<HrEmploymentExperinceRecord> HrEmploymentExperinceRecord { get; set; }
        public virtual DbSet<HrEmploymentExperinceRequest> HrEmploymentExperinceRequest { get; set; }
        public virtual DbSet<HrEmploymentQualifyRecord> HrEmploymentQualifyRecord { get; set; }
        public virtual DbSet<HrEmploymentQualifyRequest> HrEmploymentQualifyRequest { get; set; }
        public virtual DbSet<HrExperienceCategories> HrExperienceCategories { get; set; }
        public virtual DbSet<HrExperiences> HrExperiences { get; set; }
        public virtual DbSet<HrFinalFingerPrint> HrFinalFingerPrint { get; set; }
        public virtual DbSet<HrFingerPrint> HrFingerPrint { get; set; }
        public virtual DbSet<HrFpmodeStatus> HrFpmodeStatus { get; set; }
        public virtual DbSet<HrGradeHiringItem> HrGradeHiringItem { get; set; }
        public virtual DbSet<HrGradeHiringItemDtls> HrGradeHiringItemDtls { get; set; }
        public virtual DbSet<HrGradeHiringItemFixed> HrGradeHiringItemFixed { get; set; }
        public virtual DbSet<HrGradeHiringItemHdr> HrGradeHiringItemHdr { get; set; }
        public virtual DbSet<HrGradeJobGroups> HrGradeJobGroups { get; set; }
        public virtual DbSet<HrGradeVactionTicket> HrGradeVactionTicket { get; set; }
        public virtual DbSet<HrGrades> HrGrades { get; set; }
        public virtual DbSet<HrHiringEmpDuesRequestEffect> HrHiringEmpDuesRequestEffect { get; set; }
        public virtual DbSet<HrHiringEmpReceivableDuesDtls> HrHiringEmpReceivableDuesDtls { get; set; }
        public virtual DbSet<HrHiringEmpReceivableDuesHdr> HrHiringEmpReceivableDuesHdr { get; set; }
        public virtual DbSet<HrHiringEmpSocialInsuranceEffect> HrHiringEmpSocialInsuranceEffect { get; set; }
        public virtual DbSet<HrHiringItems> HrHiringItems { get; set; }
        public virtual DbSet<HrHiringMonthActuallDuesDtls> HrHiringMonthActuallDuesDtls { get; set; }
        public virtual DbSet<HrHiringMonthActuallDuesHdr> HrHiringMonthActuallDuesHdr { get; set; }
        public virtual DbSet<HrHiringMonthDelayDuesDtls> HrHiringMonthDelayDuesDtls { get; set; }
        public virtual DbSet<HrHiringMonthDelayDuesHdr> HrHiringMonthDelayDuesHdr { get; set; }
        public virtual DbSet<HrHiringMonthFollowUpDtls> HrHiringMonthFollowUpDtls { get; set; }
        public virtual DbSet<HrHiringMonthFollowUpHdr> HrHiringMonthFollowUpHdr { get; set; }
        public virtual DbSet<HrInporgressAndApprovedRequests> HrInporgressAndApprovedRequests { get; set; }
        public virtual DbSet<HrJobs> HrJobs { get; set; }
        public virtual DbSet<HrMilitaryStatuses> HrMilitaryStatuses { get; set; }
        public virtual DbSet<HrNationalities> HrNationalities { get; set; }
        public virtual DbSet<HrNotificationTypes> HrNotificationTypes { get; set; }
        public virtual DbSet<HrOfficialVacations> HrOfficialVacations { get; set; }
        public virtual DbSet<HrOverTimeTypes> HrOverTimeTypes { get; set; }
        public virtual DbSet<HrPermissionReasons> HrPermissionReasons { get; set; }
        public virtual DbSet<HrPermissionSubReasons> HrPermissionSubReasons { get; set; }
        public virtual DbSet<HrPermissionTypes> HrPermissionTypes { get; set; }
        public virtual DbSet<HrProjects> HrProjects { get; set; }
        public virtual DbSet<HrQualificationTypes> HrQualificationTypes { get; set; }
        public virtual DbSet<HrQualifications> HrQualifications { get; set; }
        public virtual DbSet<HrReligions> HrReligions { get; set; }
        public virtual DbSet<HrRequestGroupTypes> HrRequestGroupTypes { get; set; }
        public virtual DbSet<HrRequestStatus> HrRequestStatus { get; set; }
        public virtual DbSet<HrRequestTypes> HrRequestTypes { get; set; }
        public virtual DbSet<HrRequestTypesDtls> HrRequestTypesDtls { get; set; }
        public virtual DbSet<HrRewardReasons> HrRewardReasons { get; set; }
        public virtual DbSet<HrShiftGroups> HrShiftGroups { get; set; }
        public virtual DbSet<HrShiftWeekDaysDtls> HrShiftWeekDaysDtls { get; set; }
        public virtual DbSet<HrShifts> HrShifts { get; set; }
        public virtual DbSet<HrShiftsDetails> HrShiftsDetails { get; set; }
        public virtual DbSet<HrSocialInsuranceDeductionPercntgSa> HrSocialInsuranceDeductionPercntgSa { get; set; }
        public virtual DbSet<HrSocialInsuranceTypes> HrSocialInsuranceTypes { get; set; }
        public virtual DbSet<HrSocialStatuses> HrSocialStatuses { get; set; }
        public virtual DbSet<HrTicketTypes> HrTicketTypes { get; set; }
        public virtual DbSet<HrTimeAttendanceSetting> HrTimeAttendanceSetting { get; set; }
        public virtual DbSet<HrUsers> HrUsers { get; set; }
        public virtual DbSet<HrVactionTypes> HrVactionTypes { get; set; }
        public virtual DbSet<HrWeekPolicySystem> HrWeekPolicySystem { get; set; }
        public virtual DbSet<HrWeekPolicySystemDaysDtls> HrWeekPolicySystemDaysDtls { get; set; }
        public virtual DbSet<HrWeekSysDays> HrWeekSysDays { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<NewMenuNames> NewMenuNames { get; set; }
        public virtual DbSet<TestFactoryFp> TestFactoryFp { get; set; }
        public virtual DbSet<TransLog> TransLog { get; set; }
        public virtual DbSet<TxtEmployeeData> TxtEmployeeData { get; set; }
        public virtual DbSet<UserPages> UserPages { get; set; }
        public virtual DbSet<VwEmpAnnualLeavePlanRequestWorkFlowHistory> VwEmpAnnualLeavePlanRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpBorrowDelayRequestWorkFlowHistory> VwEmpBorrowDelayRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpBorrowRequestWorkFlowHistory> VwEmpBorrowRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpDisciplinaryProcedureRequestWorkFlowHistory> VwEmpDisciplinaryProcedureRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpDismissalRequestWorkFlowHistory> VwEmpDismissalRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpEmploymentRequestWorkFlowHistory> VwEmpEmploymentRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpJobMissionRequestWorkFlowHistory> VwEmpJobMissionRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpOverTimeRequestWorkFlowHistory> VwEmpOverTimeRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpPermissionRequestWorkFlowHistory> VwEmpPermissionRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpResignationRequestWorkFlowHistory> VwEmpResignationRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpRewardRequestWorkFlowHistory> VwEmpRewardRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpSecondmentRequestWorkFlowHistory> VwEmpSecondmentRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpTicketValueForAllEmployee> VwEmpTicketValueForAllEmployee { get; set; }
        public virtual DbSet<VwEmpTransferEmployeeRequestWorkFlowHistory> VwEmpTransferEmployeeRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpTravelTickectRequestWorkFlowHistory> VwEmpTravelTickectRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpVactionRequestWorkFlowHistory> VwEmpVactionRequestWorkFlowHistory { get; set; }
        public virtual DbSet<VwEmpVactionRequestWorkFlowHistoryOld> VwEmpVactionRequestWorkFlowHistoryOld { get; set; }
        public virtual DbSet<VwEmployeesCommissioner> VwEmployeesCommissioner { get; set; }
        public virtual DbSet<VwInsertVactionRequestSteps> VwInsertVactionRequestSteps { get; set; }
        public virtual DbSet<VwInsertVactionRequestStepsOld> VwInsertVactionRequestStepsOld { get; set; }
        public virtual DbSet<VwInsertVactionRequestStepsWithBranch> VwInsertVactionRequestStepsWithBranch { get; set; }
        public virtual DbSet<VwManagerEmployee> VwManagerEmployee { get; set; }
        public virtual DbSet<VwManagerEmployeeWbranch> VwManagerEmployeeWbranch { get; set; }
        public virtual DbSet<VwWorkFlow> VwWorkFlow { get; set; }
        public virtual DbSet<WorkFlowDtls> WorkFlowDtls { get; set; }
        public virtual DbSet<WorkFlowHdr> WorkFlowHdr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=PharmaERPTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppDuesAndDeductSetting>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("AppDuesAndDeduct_Setting");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AppSettingType)
                    .HasMaxLength(2)
                    .HasComment("The Values in Hr_AppSettingTypes table");

                entity.Property(e => e.CalcOnType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:DailyorMonthPackage;1:Using Hireitem");

                entity.Property(e => e.CheckedStatus)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Uncheck;1:Check");

                entity.Property(e => e.HireItemId).HasMaxLength(6);
            });

            modelBuilder.Entity<AppErrorLog>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("App_ErrorLog");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.ErrorId)
                    .HasColumnName("Error_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ErrorMessage).HasColumnName("Error_Message");

                entity.Property(e => e.FunctionName).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<AppMenus>(entity =>
            {
                entity.ToTable("APP_Menus");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idddd)
                    .HasColumnName("idddd")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MenuNameEn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo).HasMaxLength(6);

                entity.Property(e => e.PageName)
                    .HasColumnName("Page_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PageNameEn)
                    .HasColumnName("Page_NameEN")
                    .HasMaxLength(50);

                entity.Property(e => e.PathUrl).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<AppRolesMenuPriviledge>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.MenuId, e.CompanyId, e.BranchId })
                    .HasName("PK_AppRolesMenuPriviledge_1");

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.Property(e => e.MenuId).HasMaxLength(6);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CanDelete).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanInsert).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanSearch).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanUpdate).HasComment("0:No;1:Yes");

                entity.Property(e => e.IsVisiable).HasComment("0:NotVisiable;1:Visiable");
            });

            modelBuilder.Entity<AppSettings>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("App_Settings");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AbsenceCalcWayByDay)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("how many days that will be calculated if the employee was absent");

                entity.Property(e => e.AbsenceSalaryItem).HasMaxLength(6);

                entity.Property(e => e.AllowedPeriodForStopRequestEffect)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyPermissionDiscount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotApply;1:Apply");

                entity.Property(e => e.CalcWithGrade)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:WithOutGrid;1:WithGrade");

                entity.Property(e => e.ChkAbilityTransferVac)
                    .HasColumnName("chkAbilityTransferVac")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotTransfer;1:ApplyTransfer");

                entity.Property(e => e.ChkAbilityTrncferToNext)
                    .HasColumnName("chkAbilityTrncferToNext")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes transfer to next");

                entity.Property(e => e.ChkPaidByLastSal)
                    .HasColumnName("chkPaidByLastSal")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:CalcLastSal;0:No");

                entity.Property(e => e.ChkVacAfterMonth)
                    .HasColumnName("chkVacAfterMonth")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:11Month;0:12Month");

                entity.Property(e => e.DelySalaryItem).HasMaxLength(6);

                entity.Property(e => e.EmpSerialForDocNotify).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExtraSalaryItem).HasMaxLength(6);

                entity.Property(e => e.MaxTrnsferPeriod)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("MaximumAllowed transfer");

                entity.Property(e => e.PayrollDay)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((28))");

                entity.Property(e => e.PeriodDayToNotifyFinishContract).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PerioddayToForwordRequest)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseTimeInWorkFlowRequest)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No ; 1:yes");

                entity.Property(e => e.VacAllownaceBorA)
                    .HasColumnName("VacAllownaceBOrA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Before Vaction;2:afterVaction");

                entity.Property(e => e.VacAllownceSalaryItem).HasMaxLength(50);

                entity.Property(e => e.VacTicketHireItemId)
                    .HasColumnName("VacTicketHireItem_Id")
                    .HasMaxLength(6)
                    .HasComment("بدل تذاكر الطيران");

                entity.Property(e => e.VacTransferAllownceSalaryItem).HasMaxLength(50);

                entity.Property(e => e.WorkingHoursPerDay)
                    .HasColumnType("numeric(18, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AppUsersMenuPriviledge>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.MenuId, e.CompanyId, e.BranchId })
                    .HasName("PK_AppUsersMenuPriviledge_1");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.MenuId).HasMaxLength(6);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CanDelete).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanInsert).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanSearch).HasComment("0:No;1:Yes");

                entity.Property(e => e.CanUpdate).HasComment("0:No;1:Yes");

                entity.Property(e => e.IsVisiable).HasComment("0:NotVisiable;1:Visiable");
            });

            modelBuilder.Entity<ArDict>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("AR_Dict");

                entity.Property(e => e.RowId)
                    .HasColumnName("Row_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ArCode)
                    .IsRequired()
                    .HasColumnName("AR_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.ArDesc)
                    .IsRequired()
                    .HasColumnName("AR_Desc")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.AppearAllEmp)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<GroupPages>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("Group_Pages");

                entity.Property(e => e.PageId)
                    .HasColumnName("Page_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupNameEn)
                    .HasColumnName("Group_NameEN")
                    .HasMaxLength(50);

                entity.Property(e => e.UserRole)
                    .HasColumnName("User_Role")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrAbsenceTypes>(entity =>
            {
                entity.HasKey(e => e.AbsenceTypeId);

                entity.ToTable("Hr_Absence_Types");

                entity.Property(e => e.AbsenceTypeId).HasColumnName("AbsenceType_Id");

                entity.Property(e => e.AbsenceTypeName)
                    .IsRequired()
                    .HasColumnName("AbsenceType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AbsenceTypeNameConv).HasColumnName("AbsenceType_NameConv");

                entity.Property(e => e.AbsenceTypeNameEn)
                    .HasColumnName("AbsenceType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrAdministrations>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.AdminId });

                entity.ToTable("Hr_Administrations");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AdminAccountNo)
                    .HasColumnName("Admin_AccountNo")
                    .HasMaxLength(25);

                entity.Property(e => e.AdminCode)
                    .IsRequired()
                    .HasColumnName("Admin_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasColumnName("Admin_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AdminNameConv).HasColumnName("Admin_NameConv");

                entity.Property(e => e.AdminNameEn)
                    .IsRequired()
                    .HasColumnName("Admin_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.HasParent)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1:HasParent;0:Has not parent");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IsParent)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:ISParent;0:IsChild");

                entity.Property(e => e.ParentAdminId)
                    .HasColumnName("ParentAdmin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrAdministrations)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Administrations_Hr_Branches");
            });

            modelBuilder.Entity<HrAlternativeEmployeesTrans>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.RecId });

                entity.ToTable("Hr_AlternativeEmployeesTrans");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HrAppSettingTypes>(entity =>
            {
                entity.HasKey(e => e.AppSettingTypeId);

                entity.ToTable("Hr_AppSettingTypes");

                entity.Property(e => e.AppSettingTypeId)
                    .HasColumnName("AppSettingType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.AppSettingTypeName)
                    .IsRequired()
                    .HasColumnName("AppSettingType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AppSettingTypeNameEn)
                    .HasColumnName("AppSettingType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<HrAssetsGroup>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.AssetGroupId });

                entity.ToTable("Hr_Assets_Group");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AssetGroupId)
                    .HasColumnName("Asset_Group_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasColumnName("Asset_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AssetNameConv).HasColumnName("Asset_Name_Conv");

                entity.Property(e => e.AssetNameEn)
                    .IsRequired()
                    .HasColumnName("Asset_Name_En")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrAssignWorkFlowToRequest>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Hr_AssignWorkFlowToRequest");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_Hr_AssignWorkFlowToRequest")
                    .IsUnique();

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkFlowId)
                    .IsRequired()
                    .HasColumnName("WorkFlow_Id")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HrBanks>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.BankId })
                    .HasName("PK_Hr_Banks_1");

                entity.ToTable("Hr_Banks");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BankId)
                    .HasColumnName("Bank_Id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasColumnName("Bank_Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BankNameConv).HasColumnName("Bank_Name_Conv");

                entity.Property(e => e.BankNameEn)
                    .HasColumnName("Bank_Name_En")
                    .HasMaxLength(100);

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Mobile1).HasMaxLength(20);

                entity.Property(e => e.Mobile2).HasMaxLength(20);

                entity.Property(e => e.Phone1).HasMaxLength(20);

                entity.Property(e => e.Phone2).HasMaxLength(20);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.SwiftCode)
                    .HasColumnName("Swift_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.WebSiteUrl).HasMaxLength(100);
            });

            modelBuilder.Entity<HrBeginEmpReceivableDuesDtls>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.EmpSerialNo, e.HdrId });

                entity.ToTable("Hr_BeginEmpReceivableDues_Dtls");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DueDate).HasMaxLength(8);

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.InsItemDate).HasColumnType("datetime");

                entity.Property(e => e.InsItemUser).HasMaxLength(100);

                entity.Property(e => e.MonthNo)
                    .IsRequired()
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.RecRequestHdrId).HasColumnName("RecRequestHdr_Id");

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.TransItemDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrBranchAccountTypes>(entity =>
            {
                entity.HasKey(e => e.BranchAccountTypeId);

                entity.ToTable("Hr_BranchAccount_Types");

                entity.Property(e => e.BranchAccountTypeId)
                    .HasColumnName("BranchAccountType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.BranchAccountTypeName)
                    .IsRequired()
                    .HasColumnName("BranchAccountType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchAccountTypeNameEn)
                    .HasColumnName("BranchAccountType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<HrBranchAccounts>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.BranchId, e.CompanyId, e.DtlHdrId });

                entity.ToTable("Hr_BranchAccounts");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchId).HasMaxLength(15);

                entity.Property(e => e.CompanyId).HasMaxLength(15);

                entity.Property(e => e.DtlHdrId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountType).HasMaxLength(3);

                entity.Property(e => e.BankId).HasMaxLength(15);

                entity.Property(e => e.BrnchAccountNo).HasMaxLength(25);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RowState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrBranchDocNotificationDtls>(entity =>
            {
                entity.HasKey(e => new { e.NotifyRecHdrId, e.ConfirmNotifyId });

                entity.ToTable("Hr_Branch_Doc_Notification_Dtls");

                entity.Property(e => e.NotifyRecHdrId)
                    .HasColumnName("NotifyRec_Hdr_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConfirmNotifyId)
                    .HasColumnName("Confirm_NotifyId")
                    .HasComment("create by Manuallay when sending email");

                entity.Property(e => e.BranchDocDtlsId).HasColumnName("BranchDocDtls_Id");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DocTypeId)
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageStatus)
                    .HasColumnName("Message_Status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:UnRead;1:Read");

                entity.Property(e => e.ResponsibleEmail)
                    .HasColumnName("Responsible_Email")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrBranchDocsDtlsHistory>(entity =>
            {
                entity.HasKey(e => e.DtlsId)
                    .HasName("PK_Hr_Branch_Docs_Dtls");

                entity.ToTable("Hr_Branch_Docs_Dtls_History");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActuallDateNotification).HasMaxLength(8);

                entity.Property(e => e.ActuallDateNotificationHijri).HasMaxLength(8);

                entity.Property(e => e.BranchDocCode)
                    .IsRequired()
                    .HasColumnName("Branch_Doc_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchDocId)
                    .HasColumnName("Branch_Doc_Id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ConfirmNotifyId)
                    .HasColumnName("Confirm_NotifyId")
                    .HasComment("create by Manuallay when sending email");

                entity.Property(e => e.DocTypeId)
                    .IsRequired()
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.FromDateHijri).HasMaxLength(8);

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsmessageDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.IssueRegion)
                    .HasColumnName("Issue_Region")
                    .HasMaxLength(20);

                entity.Property(e => e.MessageStatus)
                    .HasColumnName("Message_Status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:UnRead;1:Read;9:UpdateDateBeforeNotify");

                entity.Property(e => e.NotifyMessage).HasColumnType("text");

                entity.Property(e => e.NotifyMessageEn).HasColumnType("text");

                entity.Property(e => e.NotifyPeriodType)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:ByDay;2:ByMonth");

                entity.Property(e => e.RegistrationNo).HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmail)
                    .HasColumnName("Responsible_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmpIdToNotify).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToBeNotifyPeriodBefore).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.ToDateHijri).HasMaxLength(8);

                entity.Property(e => e.UpdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdStatusDate).HasColumnType("datetime");

                entity.Property(e => e.UpdUser).HasMaxLength(100);

                entity.Property(e => e.UseNotifyDateType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:AD;2:Hijri");
            });

            modelBuilder.Entity<HrBranchDocsHdr>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_Branch_Docs_Hdr");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ActuallDateNotification).HasMaxLength(8);

                entity.Property(e => e.ActuallDateNotificationHijri).HasMaxLength(8);

                entity.Property(e => e.BranchDocCode)
                    .IsRequired()
                    .HasColumnName("Branch_Doc_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchDocId)
                    .HasColumnName("Branch_Doc_Id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DocTypeId)
                    .IsRequired()
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.IssueRegion)
                    .HasColumnName("Issue_Region")
                    .HasMaxLength(20);

                entity.Property(e => e.LastFromDate).HasMaxLength(8);

                entity.Property(e => e.LastFromDateHijri).HasMaxLength(8);

                entity.Property(e => e.LastToDate).HasMaxLength(8);

                entity.Property(e => e.LastToDateHijri).HasMaxLength(8);

                entity.Property(e => e.NotifyPeriodType)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:ByDay;2:ByMonth");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistrationNo).HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmpIdToNotify).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SendNotify).HasComment("0:not send;1:sending");

                entity.Property(e => e.ToBeNotifyPeriodBefore).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.UseNotifyDateType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:AD;2:Hijri");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.HrBranchDocsHdr)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Branch_Docs_Hdr_Hr_DocumentTypes");

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrBranchDocsHdr)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Branch_Docs_Hdr_Hr_Branch_Docs_Hdr");
            });

            modelBuilder.Entity<HrBranchDocuments>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.DocId });

                entity.ToTable("Hr_BranchDocuments");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DocId)
                    .HasColumnName("Doc_Id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DocName)
                    .HasColumnName("Doc_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DocNameConv).HasColumnName("Doc_Name_Conv");

                entity.Property(e => e.DocNameEn)
                    .HasColumnName("Doc_Name_En")
                    .HasMaxLength(100);

                entity.Property(e => e.EndDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.IssueRegion)
                    .HasColumnName("Issue_Region")
                    .HasMaxLength(20);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.StartDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrBranches>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId });

                entity.ToTable("Hr_Branches");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchAccountNo)
                    .HasColumnName("Branch_AccountNo")
                    .HasMaxLength(25);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasColumnName("Branch_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasColumnName("Branch_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchNameConv).HasColumnName("Branch_NameConv");

                entity.Property(e => e.BranchNameEn)
                    .IsRequired()
                    .HasColumnName("Branch_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.BuidingNumber)
                    .HasColumnName("Buiding_Number")
                    .HasMaxLength(6);

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExtenstionTel1).HasMaxLength(15);

                entity.Property(e => e.ExtenstionTel2).HasMaxLength(15);

                entity.Property(e => e.ExtenstionTel3).HasMaxLength(15);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.POBox)
                    .HasColumnName("P_O_Box")
                    .HasMaxLength(15);

                entity.Property(e => e.Phone1).HasMaxLength(15);

                entity.Property(e => e.Phone2).HasMaxLength(15);

                entity.Property(e => e.Phone3).HasMaxLength(15);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ResponsibleEmpId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StreetName).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.HrBranches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Branches_Hr_Companies");
            });

            modelBuilder.Entity<HrCities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("Hr_Cities");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CityCode)
                    .HasColumnName("City_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CityNameConv).HasColumnName("City_NameConv");

                entity.Property(e => e.CityNameEn)
                    .HasColumnName("City_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("Country_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrCompanies>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("Hr_Companies");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyAccountNo)
                    .HasColumnName("Company_AccountNo")
                    .HasMaxLength(25);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasColumnName("Company_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyNameConv).HasColumnName("Company_NameConv");

                entity.Property(e => e.CompanyNameEn)
                    .IsRequired()
                    .HasColumnName("Company_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.FieldAr)
                    .HasColumnName("Field_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.FieldEn)
                    .HasColumnName("Field_En")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.LogoPath).HasColumnName("Logo_Path");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ResponsibleEmpId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrCompaniesTree>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_Hr_CompaniesTree_1");

                entity.ToTable("Hr_CompaniesTree");

                entity.Property(e => e.AccountId)
                    .HasColumnName("Account_Id")
                    .HasMaxLength(25);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnName("Account_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountNameConv).HasColumnName("Account_NameConv");

                entity.Property(e => e.AccountNameEn)
                    .HasColumnName("Account_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountParentId)
                    .IsRequired()
                    .HasColumnName("Account_Parent_Id")
                    .HasMaxLength(25);

                entity.Property(e => e.AccountTreeType)
                    .HasColumnName("Account_Tree_Type")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Company;2:Branch:3:Administration;4:Department");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecSerialId)
                    .HasColumnName("Rec_Serial_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Hr_Countries");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("Country_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryNameConv).HasColumnName("Country_NameConv");

                entity.Property(e => e.CountryNameEn)
                    .HasColumnName("Country_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrCurrencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("Hr_Currencies");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasColumnName("Currency_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrencyNameConv).HasColumnName("Currency_NameConv");

                entity.Property(e => e.CurrencyNameEn)
                    .HasColumnName("Currency_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrDailyTimeSheet>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_DailyTimeSheet");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ApplyAbsence)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyDely)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyExtra)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Confirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayCode).HasMaxLength(1);

                entity.Property(e => e.DayType).HasMaxLength(1);

                entity.Property(e => e.DelyAmountInMinut).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiffDelyInMinut)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiffExtraInMinut)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpCheckInTime)
                    .HasColumnName("Emp_Check_InTime")
                    .HasMaxLength(4);

                entity.Property(e => e.EmpCheckOutTime)
                    .HasColumnName("Emp_Check_OutTime")
                    .HasMaxLength(4);

                entity.Property(e => e.EmpInVacation)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExtraAmountInMinut).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo).HasMaxLength(6);

                entity.Property(e => e.OvertimePeriodFrmRqustInMinute)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PermissionPeriodFrmRqustInMinute)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.Transdate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.WorkingHours)
                    .HasColumnName("Working_Hours")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<HrDayTypes>(entity =>
            {
                entity.HasKey(e => e.DayTypeId);

                entity.ToTable("Hr_DayTypes");

                entity.Property(e => e.DayTypeId).HasMaxLength(1);

                entity.Property(e => e.DayTypeName).HasMaxLength(50);

                entity.Property(e => e.DayTypeNameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<HrDeductionReasons>(entity =>
            {
                entity.HasKey(e => e.DeductionReasonId);

                entity.ToTable("Hr_DeductionReasons");

                entity.Property(e => e.DeductionReasonId)
                    .HasColumnName("DeductionReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeductionReasonCode)
                    .HasColumnName("DeductionReason_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.DeductionReasonName)
                    .IsRequired()
                    .HasColumnName("DeductionReason_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionReasonNameConv).HasColumnName("DeductionReason_NameConv");

                entity.Property(e => e.DeductionReasonNameEn)
                    .HasColumnName("DeductionReason_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrDepartments>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.DeptId });

                entity.ToTable("Hr_Departments");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeptId)
                    .HasColumnName("Dept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DeptAccountNo)
                    .HasColumnName("Dept_AccountNo")
                    .HasMaxLength(25);

                entity.Property(e => e.DeptCode)
                    .IsRequired()
                    .HasColumnName("Dept_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("Dept_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeptNameConv).HasColumnName("Dept_NameConv");

                entity.Property(e => e.DeptNameEn)
                    .IsRequired()
                    .HasColumnName("Dept_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrAdministrations)
                    .WithMany(p => p.HrDepartments)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.AdminId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Departments_Hr_Administrations");
            });

            modelBuilder.Entity<HrDisciplinaryProcedures>(entity =>
            {
                entity.HasKey(e => e.DisciplinaryProcedureId)
                    .HasName("PK_Hr_Disciplinaryprocedures");

                entity.ToTable("Hr_DisciplinaryProcedures");

                entity.Property(e => e.DisciplinaryProcedureId)
                    .HasColumnName("DisciplinaryProcedure_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DisciplinaryProcedureCode)
                    .HasColumnName("DisciplinaryProcedure_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.DisciplinaryProcedureName)
                    .IsRequired()
                    .HasColumnName("DisciplinaryProcedure_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DisciplinaryProcedureNameConv).HasColumnName("DisciplinaryProcedure_NameConv");

                entity.Property(e => e.DisciplinaryProcedureNameEn)
                    .HasColumnName("DisciplinaryProcedure_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.DiscountType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Moral;2:DiscountMoney");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrDismissalReasons>(entity =>
            {
                entity.HasKey(e => e.DismissalReasonId);

                entity.ToTable("Hr_DismissalReasons");

                entity.Property(e => e.DismissalReasonId)
                    .HasColumnName("DismissalReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DismissalReasonCode)
                    .HasColumnName("DismissalReason_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.DismissalReasonName)
                    .IsRequired()
                    .HasColumnName("DismissalReason_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DismissalReasonNameConv).HasColumnName("DismissalReason_NameConv");

                entity.Property(e => e.DismissalReasonNameEn)
                    .HasColumnName("DismissalReason_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrDocumentTypes>(entity =>
            {
                entity.HasKey(e => e.DocTypeId);

                entity.ToTable("Hr_DocumentTypes");

                entity.Property(e => e.DocTypeId)
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DocType)
                    .HasColumnName("Doc_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Company;2:Employee");

                entity.Property(e => e.DocTypeCode)
                    .HasColumnName("Doc_Type_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.DocTypeName)
                    .IsRequired()
                    .HasColumnName("Doc_Type_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DocTypeNameConv).HasColumnName("Doc_Type_NameConv");

                entity.Property(e => e.DocTypeNameEn)
                    .HasColumnName("Doc_Type_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpAbsenceRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpAbsenceRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .HasComment("This is the number of order");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpAbsenceRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpAbsenceRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpAccomdationFeesDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_EmpAccomdationFees_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccomdtionFeeMonthNo)
                    .HasColumnName("AccomdtionFee_Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.AccomdtionFeeMonthStatus).HasColumnName("AccomdtionFee_Month_Status");

                entity.Property(e => e.AccomdtionFeeMonthValue)
                    .HasColumnName("AccomdtionFee_Month_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");
            });

            modelBuilder.Entity<HrEmpAccomdationFeesHdr>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpAccomdationFees_Hdr1");

                entity.ToTable("Hr_EmpAccomdationFees_Hdr");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AccomdtionFeeDuesDate).HasMaxLength(8);

                entity.Property(e => e.AccomdtionFeeMonthValue)
                    .HasColumnName("AccomdtionFee_MonthValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.AccomdtionFeePeriod)
                    .HasColumnName("AccomdtionFee_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccomdtionFeeStartDate).HasMaxLength(8);

                entity.Property(e => e.AccomdtionFeeStatus).HasColumnName("AccomdtionFee_Status");

                entity.Property(e => e.AccomdtionFeeValue)
                    .HasColumnName("AccomdtionFee_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyFeesValue)
                    .HasColumnName("CompanyFees_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate).HasColumnType("datetime");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.TotalAllaccomdationValue)
                    .HasColumnName("TotalALLAccomdationValue")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transdate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpAccomdationFeesOrgDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_EmpAccomdationFees_OrgDtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccomdtionFeeMonthNo)
                    .HasColumnName("AccomdtionFee_Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.AccomdtionFeeMonthStatus).HasColumnName("AccomdtionFee_Month_Status");

                entity.Property(e => e.AccomdtionFeeMonthValue)
                    .HasColumnName("AccomdtionFee_Month_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");
            });

            modelBuilder.Entity<HrEmpAccomdationFeesOrgHdr>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpAccomdationFees_OrgHdr");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AccomdtionFeeDuesDate).HasMaxLength(8);

                entity.Property(e => e.AccomdtionFeeMonthValue)
                    .HasColumnName("AccomdtionFee_MonthValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.AccomdtionFeePeriod)
                    .HasColumnName("AccomdtionFee_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccomdtionFeeStartDate).HasMaxLength(8);

                entity.Property(e => e.AccomdtionFeeStatus).HasColumnName("AccomdtionFee_Status");

                entity.Property(e => e.AccomdtionFeeValue)
                    .HasColumnName("AccomdtionFee_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyFeesValue)
                    .HasColumnName("CompanyFees_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate).HasColumnType("datetime");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.ReceivedFeesValue)
                    .HasColumnName("ReceivedFees_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAllaccomdationValue)
                    .HasColumnName("TotalALLAccomdationValue")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transdate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpAccomdationFeesSetting>(entity =>
            {
                entity.ToTable("Hr_EmpAccomdationFees_Setting");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.TotHireItemId)
                    .HasColumnName("TotHireItem_Id")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HrEmpAnnualLeavePlanRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpAnnualLeavePlanRecord_1");

                entity.ToTable("Hr_EmpAnnualLeavePlanRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.YearOfPlan).HasMaxLength(4);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpAnnualLeavePlanRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpAnnualLeavePlanRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpAnnualLeavePlanRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpAnnualLeavePlanRequest_1");

                entity.ToTable("Hr_EmpAnnualLeavePlanRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.YearOfPlan).HasMaxLength(4);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpAnnualLeavePlanRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpAnnualLeavePlanRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpAnnualLeavePlanRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpAnnualLeavePlanRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpAssets>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_Emp_Assets");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AssetGroupId)
                    .HasColumnName("Asset_Group_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AssetValue)
                    .HasColumnName("Asset_Value")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecieptNo)
                    .HasColumnName("Reciept_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Transdate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrAssetsGroup)
                    .WithMany(p => p.HrEmpAssets)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.AssetGroupId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Emp_Assets_Hr_Assets_Group");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpAssets)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Emp_Assets_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpAttendanceDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_EmpAttendance_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AfterCheckIn)
                    .HasColumnName("AfterCheck_In")
                    .HasMaxLength(1);

                entity.Property(e => e.AfterCheckInEffectInMin)
                    .HasColumnName("AfterCheck_In_EffectInMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AfterCheckOut)
                    .HasColumnName("AfterCheck__OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.AfterCheckOutEffectInMin)
                    .HasColumnName("AfterCheck__OUT_EffectInMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BeforeCheckIn)
                    .HasColumnName("BeforeCheck_In")
                    .HasMaxLength(1);

                entity.Property(e => e.BeforeCheckInEffectInMin)
                    .HasColumnName("BeforeCheck_In_EffectInMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BeforeCheckOut)
                    .HasColumnName("BeforeCheck_OUT")
                    .HasMaxLength(1);

                entity.Property(e => e.BeforeCheckOutEffectInMin)
                    .HasColumnName("BeforeCheck_OUT_EffectInMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EmpCheckInTime)
                    .HasColumnName("Emp_Check_InTime")
                    .HasMaxLength(4);

                entity.Property(e => e.EmpCheckOutTime)
                    .HasColumnName("Emp_Check_OutTime")
                    .HasMaxLength(4);

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ShiftFromTime)
                    .HasColumnName("Shift_FromTime")
                    .HasMaxLength(4);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftToTime)
                    .HasColumnName("Shift_ToTime")
                    .HasMaxLength(4);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.WorkingPeriodWithShftInMinute).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.RecHdr)
                    .WithMany(p => p.HrEmpAttendanceDtls)
                    .HasForeignKey(d => d.RecHdrId)
                    .HasConstraintName("FK_Hr_EmpAttendance_Dtls_Hr_EmpAttendance_Dtls");
            });

            modelBuilder.Entity<HrEmpAttendanceHdr>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpAttendance_Hdr_1");

                entity.ToTable("Hr_EmpAttendance_Hdr");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DailyWorkingPeriodInMinute).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo).HasMaxLength(6);

                entity.Property(e => e.Transdate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmpBeginAnnualVacTransferdBal>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.RecNo });

                entity.ToTable("Hr_EmpBeginAnnualVacTransferdBal");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.Insdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotBalByDays).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Transdate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmpBorrowDelayRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpBorrowDelayRecord_1");

                entity.ToTable("Hr_EmpBorrowDelayRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BorrowHdrId).HasColumnName("BorrowHdr_Id");

                entity.Property(e => e.BorrowMonthDtls).HasColumnName("Borrow_Month_Dtls");

                entity.Property(e => e.BorrowMonthNo)
                    .HasColumnName("Borrow_Month_No")
                    .HasMaxLength(8);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SendToEmpDuesRequest)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Not;1:Send");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpBorrowDelayRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpBorrowDelayRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpBorrowDelayRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpBorrowDelayRequest_1");

                entity.ToTable("Hr_EmpBorrowDelayRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BorrowHdrId).HasColumnName("BorrowHdr_Id");

                entity.Property(e => e.BorrowMonthDtls).HasColumnName("Borrow_Month_Dtls");

                entity.Property(e => e.BorrowMonthNo)
                    .HasColumnName("Borrow_Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.BorrowName).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpBorrowDelayRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpBorrowDelayRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpBorrowDelayRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpBorrowDelayRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No;9:NotReplaywithinPeriod");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpBorrowDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_EmpBorrow_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BorrowMonthNo)
                    .HasColumnName("Borrow_Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.BorrowMonthStatus)
                    .HasColumnName("Borrow_Month_Status")
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:paid;2:active;3:tobepaid");

                entity.Property(e => e.BorrowMonthValue)
                    .HasColumnName("Borrow_Month_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.HrEmpBorrowHdr)
                    .WithMany(p => p.HrEmpBorrowDtls)
                    .HasForeignKey(d => new { d.HdrId, d.CompanyId, d.BranchId })
                    .HasConstraintName("FK_Hr_EmpBorrow_Dtls_Hr_EmpBorrow_Hdr");
            });

            modelBuilder.Entity<HrEmpBorrowHdr>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpBorrow_Hdr");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BorrowDuesDate).HasMaxLength(8);

                entity.Property(e => e.BorrowMonthValue)
                    .HasColumnName("Borrow_MonthValue")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BorrowPeriod)
                    .HasColumnName("Borrow_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BorrowStartDate).HasMaxLength(8);

                entity.Property(e => e.BorrowStatus)
                    .HasColumnName("Borrow_Status")
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:Frozen;2:Active");

                entity.Property(e => e.BorrowValue)
                    .HasColumnName("Borrow_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.Transdate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpBorrowRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpBorrowRequest_1");

                entity.ToTable("Hr_EmpBorrowRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BorrowDuesDate).HasMaxLength(8);

                entity.Property(e => e.BorrowMonthValue)
                    .HasColumnName("Borrow_MonthValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.BorrowPeriod)
                    .HasColumnName("Borrow_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BorrowStartDate).HasMaxLength(8);

                entity.Property(e => e.BorrowValue)
                    .HasColumnName("Borrow_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpBorrowRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpBorrowRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpBorrowRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpBorrowRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpBorrowSettings>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpBorrow_Settings");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AllowExceedMaxValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotAllowed;1:Allowed");

                entity.Property(e => e.AllowedValueNotExceedTo).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<HrEmpCertifications>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpCertifications");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CertificationName)
                    .HasColumnName("Certification_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.CertificationNo)
                    .HasColumnName("Certification_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Degree)
                    .HasMaxLength(6)
                    .HasComment("1:NotPass;2Acceptable;3:good;4:VeryGood;5:Excellent");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MajorName)
                    .HasColumnName("Major_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Place).HasMaxLength(200);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpCertifications)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpCertifications_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpContractFinishNotifictions>(entity =>
            {
                entity.HasKey(e => new { e.RecNotifyNo, e.NotifyHdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpContractFinishNotifictions");

                entity.Property(e => e.RecNotifyNo)
                    .HasColumnName("RecNotify_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EndContract).HasMaxLength(8);

                entity.Property(e => e.FinishMonthNo)
                    .HasColumnName("FinishMonth_No")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecContractHdrId).HasColumnName("RecContractHdr_Id");

                entity.Property(e => e.ResponsibleEmpIdToNotify).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<HrEmpContracts>(entity =>
            {
                entity.HasKey(e => e.EmpContractId);

                entity.ToTable("Hr_EmpContracts");

                entity.Property(e => e.EmpContractId)
                    .HasColumnName("EmpContract_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.EmpContractName)
                    .IsRequired()
                    .HasColumnName("EmpContract_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpContractNameConv).HasColumnName("EmpContract_NameConv");

                entity.Property(e => e.EmpContractNameEn)
                    .HasColumnName("EmpContract_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpDelayRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpDelayRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DelayPeriod)
                    .HasColumnName("Delay_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .HasComment("This is the number of order");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDelayRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpDelayRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDisciplinaryProcedureRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDisciplinaryProcedureRecord_1");

                entity.ToTable("Hr_EmpDisciplinaryProcedureRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DisciplinaryProcedureId)
                    .HasColumnName("DisciplinaryProcedure_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DiscountApplyDate).HasMaxLength(8);

                entity.Property(e => e.DiscountType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Moral;2:DiscountMoney");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDisciplinaryProcedureRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpDisciplinaryProcedureRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDisciplinaryProcedureRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpDisciplinaryProcedureRequest_1");

                entity.ToTable("Hr_EmpDisciplinaryProcedureRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DisciplinaryProcedureId)
                    .HasColumnName("DisciplinaryProcedure_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DiscountApplyDate).HasMaxLength(8);

                entity.Property(e => e.DiscountType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Moral;2:DiscountMoney");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDisciplinaryProcedureRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpDisciplinaryProcedureRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDisciplinaryProcedureRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpDisciplinaryProcedureRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpDismissalRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDismissalRecord_1");

                entity.ToTable("Hr_EmpDismissalRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DismissalReasonId)
                    .HasColumnName("DismissalReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDismissalRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpDismissalRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDismissalRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpDismissalRequest_1");

                entity.ToTable("Hr_EmpDismissalRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DismissalReasonId)
                    .HasColumnName("DismissalReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDismissalRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpDismissalRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDismissalRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpDismissalRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpDocNotificationDtls>(entity =>
            {
                entity.HasKey(e => new { e.NotifyRecHdrId, e.ConfirmNotifyId });

                entity.ToTable("Hr_Emp_Doc_Notification_Dtls");

                entity.Property(e => e.NotifyRecHdrId)
                    .HasColumnName("NotifyRec_Hdr_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConfirmNotifyId)
                    .HasColumnName("Confirm_NotifyId")
                    .HasComment("create by Manuallay when sending email");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DocTypeId)
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpDocDtlsId).HasColumnName("EmpDocDtls_Id");

                entity.Property(e => e.EmpSerialNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageStatus)
                    .HasColumnName("Message_Status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:UnRead;1:Read");

                entity.Property(e => e.OwnerEmpDoc).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ResponsibleEmail)
                    .HasColumnName("Responsible_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:HrResponsible;2:Employee");
            });

            modelBuilder.Entity<HrEmpDocsDtlsHistory>(entity =>
            {
                entity.HasKey(e => e.DtlsId)
                    .HasName("PK_Hr_Emp_Docs_Dtls");

                entity.ToTable("Hr_Emp_Docs_Dtls_History");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActuallDateNotification).HasMaxLength(8);

                entity.Property(e => e.ActuallDateNotificationHijri).HasMaxLength(8);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ConfirmNotifyId)
                    .HasColumnName("Confirm_NotifyId")
                    .HasComment("create by Manuallay when sending email");

                entity.Property(e => e.DocTypeId)
                    .IsRequired()
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpDocCode)
                    .IsRequired()
                    .HasColumnName("Emp_Doc_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpDocId)
                    .HasColumnName("Emp_Doc_Id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.FromDateHijri).HasMaxLength(8);

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsMessageDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.IssueRegion)
                    .HasColumnName("Issue_Region")
                    .HasMaxLength(20);

                entity.Property(e => e.MessageStatus)
                    .HasColumnName("Message_Status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:UnRead;1:Read");

                entity.Property(e => e.NotifyMessage).HasColumnType("text");

                entity.Property(e => e.NotifyMessageEn).HasColumnType("text");

                entity.Property(e => e.NotifyPeriodType)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:ByDay;2:ByMonth");

                entity.Property(e => e.OwnerEmpDoc).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegistrationNo).HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmail)
                    .HasColumnName("Responsible_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmpIdToNotify).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToBeNotifyPeriodBefore).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.ToDateHijri).HasMaxLength(8);

                entity.Property(e => e.UpdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdStatusDate).HasColumnType("datetime");

                entity.Property(e => e.UpdUser).HasMaxLength(100);

                entity.Property(e => e.UseNotifyDateType).HasComment("0:Melady;1:Hijri");
            });

            modelBuilder.Entity<HrEmpDocsHdr>(entity =>
            {
                entity.HasKey(e => new { e.HdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_Emp_Docs_Hdr");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ActuallDateNotification).HasMaxLength(8);

                entity.Property(e => e.ActuallDateNotificationHijri).HasMaxLength(8);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DocTypeId)
                    .IsRequired()
                    .HasColumnName("Doc_Type_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpDocCode)
                    .IsRequired()
                    .HasColumnName("Emp_Doc_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpDocId)
                    .HasColumnName("Emp_Doc_Id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.IssueRegion)
                    .HasColumnName("Issue_Region")
                    .HasMaxLength(20);

                entity.Property(e => e.LastFromDate).HasMaxLength(8);

                entity.Property(e => e.LastFromDateHijri).HasMaxLength(8);

                entity.Property(e => e.LastToDate).HasMaxLength(8);

                entity.Property(e => e.LastToDateHijri).HasMaxLength(8);

                entity.Property(e => e.NotifyPeriodType)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:ByDay;2:ByMonth");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistrationNo).HasMaxLength(50);

                entity.Property(e => e.ResponsibleEmpIdToNotify).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SendNotify).HasComment("0:not send;1:sending");

                entity.Property(e => e.ToBeNotifyPeriodBefore).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.UseNotifyDateType).HasComment("0:Melady;1:Hijri");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.HrEmpDocsHdr)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Emp_Docs_Hdr_Hr_DocumentTypes");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpDocsHdr)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Emp_Docs_Hdr_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpDues>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDues_1");

                entity.ToTable("Hr_EmpDues");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GradeId)
                    .IsRequired()
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RowState)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:insert;1:insertAfterUpdte");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpDuesHistory>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDues_History_1");

                entity.ToTable("Hr_EmpDues_History");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeIdNew)
                    .HasColumnName("Grade_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobId)
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobIdNew)
                    .HasColumnName("GradeJob_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HireItemValueNew)
                    .HasColumnName("HireItem_Value_New")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecIdOrg)
                    .HasColumnName("Rec_id_Org")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:insert;1:insertAfterUpdte");

                entity.Property(e => e.RowState)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transdate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmpDuesVactionTicket>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDuesVactionTicket_1");

                entity.ToTable("Hr_EmpDuesVactionTicket");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InternationalWorkTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LocalWorkTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.RecStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.VactionPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VactionTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.WorkingMonthNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("the no of Month that you are working to deserve the vacation");

                entity.Property(e => e.WorkingPeriodType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:ByYear;2:ByMonth");
            });

            modelBuilder.Entity<HrEmpDuesVactionTicketHistory>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpDuesVactionTicketHistory_1");

                entity.ToTable("Hr_EmpDuesVactionTicketHistory");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DtlsIdOrg)
                    .HasColumnName("Dtls_Id_Org")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobIdNew)
                    .HasColumnName("GradeJob_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InternationalWorkTicketType).HasMaxLength(1);

                entity.Property(e => e.InternationalWorkTicketTypeNew).HasMaxLength(1);

                entity.Property(e => e.LocalWorkTicketType).HasMaxLength(1);

                entity.Property(e => e.LocalWorkTicketTypeNew).HasMaxLength(1);

                entity.Property(e => e.RecStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.VactionPeriod)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VactionPeriodNew)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VactionTicketType).HasMaxLength(1);

                entity.Property(e => e.VactionTicketTypeNew).HasMaxLength(1);

                entity.Property(e => e.WorkingMonthNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("the no of Month that you are working to deserve the vacation");

                entity.Property(e => e.WorkingMonthNoNew)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("the no of Month that you are working to deserve the vacation");

                entity.Property(e => e.WorkingPeriodType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:ByYear;2:ByMonth");

                entity.Property(e => e.WorkingPeriodTypeNew)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:ByYear;2:ByMonth");
            });

            modelBuilder.Entity<HrEmpEmploymentRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpEmploymentRecord_1");

                entity.ToTable("Hr_EmpEmploymentRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeptId)
                    .HasColumnName("Dept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.WithinBudget)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Within;2:WithOut");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpEmploymentRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpEmploymentRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpEmploymentRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpEmploymentRequest_1");

                entity.ToTable("Hr_EmpEmploymentRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeptId)
                    .HasColumnName("Dept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.WithinBudget)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Within;2:WithOut");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpEmploymentRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpEmploymentRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpEmploymentRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpEmploymentRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpExperiences>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpExperiences");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExperienceCategoryId)
                    .HasColumnName("ExperienceCategory_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceId)
                    .HasColumnName("Experience_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceName)
                    .HasColumnName("Experience_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("Job_Title")
                    .HasMaxLength(100);

                entity.Property(e => e.Place).HasMaxLength(200);

                entity.Property(e => e.ReferenceType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:selfStudy;2:Trainning");

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpExperiences)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpExperiences_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpExtraRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpExtraRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:WorkingDay;2:VactionDay");

                entity.Property(e => e.ExtraPeriod)
                    .HasColumnName("Extra_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .HasComment("This is the number of order");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpExtraRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpExtraRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpHiringMonthStatus>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.Id });

                entity.ToTable("Hr_Emp_HiringMonthStatus");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdoptedIsDone)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes");

                entity.Property(e => e.MonthNo).HasMaxLength(6);

                entity.Property(e => e.PreparedIsDone)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes");
            });

            modelBuilder.Entity<HrEmpJobMissionRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpJobMissionRecord_1");

                entity.ToTable("Hr_EmpJobMissionRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.PermissionDate).HasMaxLength(8);

                entity.Property(e => e.PermissionPeriod)
                    .HasColumnName("Permission_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SendToEmpDuesRequest)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Not;1:Send");

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpJobMissionRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpJobMissionRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpJobMissionRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpJobMissionRequest_1");

                entity.ToTable("Hr_EmpJobMissionRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.PermissionDate).HasMaxLength(8);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpJobMissionRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpJobMissionRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpJobMissionRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpJobMissionRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No;9:NotReplaywithinPeriod");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpOtherMonthlyValueRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpOtherMonthlyValueRecord_1");

                entity.ToTable("Hr_EmpOtherMonthlyValueRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo).HasMaxLength(6);

                entity.Property(e => e.MonthlyValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpOtherMonthlyValueRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpOtherMonthlyValueRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpOverTimeOrder>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpOverTimeOrder");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectEmpSerialNo)
                    .HasColumnName("DirectEmp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectManagerComment)
                    .HasColumnName("DirectManager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.HrManagerComment)
                    .HasColumnName("Hr_Manager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.HrManagerSerialNo)
                    .HasColumnName("Hr_Manager_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.OverTimePeriod)
                    .HasColumnName("OverTime_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.OverTimeTypeId).HasColumnName("OverTimeType_Id");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpOverTimeOrder)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpOverTimeOrder_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpOverTimeOrderHistory>(entity =>
            {
                entity.HasKey(e => e.HdrId);

                entity.ToTable("Hr_EmpOverTimeOrder_History");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserComment).HasColumnType("text");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpOverTimeRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpOverTimeRecord_1");

                entity.ToTable("Hr_EmpOverTimeRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:WorkingDay;2:VactionDay");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OverTimeDate).HasMaxLength(8);

                entity.Property(e => e.OverTimePeriod)
                    .HasColumnName("OverTime_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpOverTimeRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpOverTimeRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpOverTimeRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpOverTimeRequest_1");

                entity.ToTable("Hr_EmpOverTimeRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:WorkingDay;2:VactionDay");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.OverTimeDate).HasMaxLength(8);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpOverTimeRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpOverTimeRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpOverTimeRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpOverTimeRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpOverTimeSettings>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpOverTime_Settings");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CalcHourInVactionDay).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CalcHourInWorkingDay).HasColumnType("numeric(18, 3)");
            });

            modelBuilder.Entity<HrEmpPermissionOrder>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpPermissionOrder");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectEmpSerialNo)
                    .HasColumnName("DirectEmp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectManagerComment)
                    .HasColumnName("DirectManager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.HrManagerComment)
                    .HasColumnName("Hr_Manager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.HrManagerSerialNo)
                    .HasColumnName("Hr_Manager_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.PermissionPeriod)
                    .HasColumnName("Permission_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionType_Id");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpPermissionOrder)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpPermissionOrder_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpPermissionOrderHistory>(entity =>
            {
                entity.HasKey(e => e.HdrId);

                entity.ToTable("Hr_EmpPermissionOrder_History");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserComment).HasColumnType("text");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpPermissionRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpPermissionRecord_1");

                entity.ToTable("Hr_EmpPermissionRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.PermissionDate).HasMaxLength(8);

                entity.Property(e => e.PermissionPeriod)
                    .HasColumnName("Permission_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PermissionReasonId)
                    .HasColumnName("Permission_Reason_Id")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionReasonSubId)
                    .HasColumnName("Permission_Reason_Sub_Id")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionType)
                    .HasColumnName("Permission_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Personal;2:JobMission");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SendToEmpDuesRequest)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Not;1:Send");

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpPermissionRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpPermissionRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpPermissionRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpPermissionRequest_1");

                entity.ToTable("Hr_EmpPermissionRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasMaxLength(4);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.PermissionDate).HasMaxLength(8);

                entity.Property(e => e.PermissionReasonId)
                    .HasColumnName("Permission_Reason_Id")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionReasonSubId)
                    .HasColumnName("Permission_Reason_Sub_Id")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionType)
                    .HasColumnName("Permission_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Personal;2:JobMission");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToTime).HasMaxLength(4);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpPermissionRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpPermissionRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpPermissionRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpPermissionRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No;9:NotReplaywithinPeriod");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpPermissionSettings>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpPermission_Settings");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AllowToExceedDayValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotExceed;1:Exceed");

                entity.Property(e => e.AllowToExceedMonthValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotExceed;1:Exceed");

                entity.Property(e => e.AllowedValueInDayByHour).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.AllowedValueInMonthByHour).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.HourNoForDiscount).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.OnlyApplyDiscount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes Applay");

                entity.Property(e => e.PeriodForDay).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<HrEmpQualifications>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpQualifications");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasMaxLength(200);

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.Degree)
                    .HasMaxLength(6)
                    .HasComment("1:NotPass;2Acceptable;3:good;4:VeryGood;5:Excellent");

                entity.Property(e => e.FacultyName)
                    .HasColumnName("Faculty_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.QualificationId)
                    .HasColumnName("Qualification_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.Specialization).HasMaxLength(200);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.UniversityName)
                    .HasColumnName("University_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpQualifications)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpQualifications_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpRequestNotify>(entity =>
            {
                entity.HasKey(e => new { e.NotifyHdrId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpRequestNotify");

                entity.Property(e => e.NotifyHdrId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNoNotify)
                    .HasColumnName("Alternate_Emp_Serial_NoNotify")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .IsRequired()
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SenderName).IsRequired();

                entity.Property(e => e.SenderNameEn).IsRequired();
            });

            modelBuilder.Entity<HrEmpResignationRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpResignationRecord_1");

                entity.ToTable("Hr_EmpResignationRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ResignationDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpResignationRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpResignationRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpResignationRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpResignationRequest_1");

                entity.ToTable("Hr_EmpResignationRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ResignationDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpResignationRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpResignationRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpResignationRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpResignationRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpRewardRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpRewardRecord_1");

                entity.ToTable("Hr_EmpRewardRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeliveredDate).HasMaxLength(8);

                entity.Property(e => e.EmpDuesHdrId).HasColumnName("EmpDuesHdr_Id");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.RewardReasonId)
                    .HasColumnName("RewardReason_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.RewardType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Value;2:Moral");

                entity.Property(e => e.RewardValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Value;2:Moral");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpRewardRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpRewardRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpRewardRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpRewardRequest_1");

                entity.ToTable("Hr_EmpRewardRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeliveredDate).HasMaxLength(8);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.RewardReasonId)
                    .HasColumnName("RewardReason_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.RewardType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Value;2:Moral");

                entity.Property(e => e.RewardValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Value;2:Moral");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpRewardRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpRewardRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpRewardRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpRewardRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpSecondmentRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpSecondmentRecord_1");

                entity.ToTable("Hr_EmpSecondmentRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DailySecondmentValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromSecondmentDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SecondmentType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Inside;2:Outside");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.ToSecondmentDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpSecondmentRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpSecondmentRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpSecondmentRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpSecondmentRequest_1");

                entity.ToTable("Hr_EmpSecondmentRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DailySecondmentValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedValue)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromSecondmentDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SecondmentType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Inside;2:Outside");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.ToSecondmentDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpSecondmentRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpSecondmentRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpSecondmentRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpSecondmentRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpSecondmentSetting>(entity =>
            {
                entity.ToTable("Hr_EmpSecondment_Setting");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpSkills>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpSkills");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EfficiencyDegree)
                    .HasColumnName("Efficiency_Degree")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceName)
                    .HasColumnName("Experience_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpSkills)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpSkills_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpSons>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpSons_1");

                entity.ToTable("Hr_EmpSons");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeathDate).HasMaxLength(8);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.NationalEndDate).HasMaxLength(8);

                entity.Property(e => e.NationalId)
                    .HasColumnName("National_Id")
                    .HasMaxLength(25);

                entity.Property(e => e.NationalStartDate).HasMaxLength(8);

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RowState)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:insert;1:insertAfterUpdte");

                entity.Property(e => e.SonBithDate).HasMaxLength(8);

                entity.Property(e => e.SonGenederId)
                    .HasColumnName("SonGeneder_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.SonInsuranceExpiryDate).HasMaxLength(8);

                entity.Property(e => e.SonInsuranceIssueDate).HasMaxLength(8);

                entity.Property(e => e.SonInsuranceNo).HasMaxLength(25);

                entity.Property(e => e.SonNameArabic).HasMaxLength(200);

                entity.Property(e => e.SonNameEn).HasMaxLength(200);

                entity.Property(e => e.SonNationalityId)
                    .HasColumnName("SonNationality_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.SonPassportExpiryDate).HasMaxLength(8);

                entity.Property(e => e.SonPassportIssueDate).HasMaxLength(8);

                entity.Property(e => e.SonPassportNo).HasMaxLength(25);

                entity.Property(e => e.SonQualifyId)
                    .HasColumnName("SonQualify_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SonSocialStatusId)
                    .HasColumnName("SonSocial_Status_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpSpouses>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpSpouses_1");

                entity.ToTable("Hr_EmpSpouses");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MarriedDate).HasMaxLength(8);

                entity.Property(e => e.NationalEndDate).HasMaxLength(8);

                entity.Property(e => e.NationalId)
                    .HasColumnName("National_Id")
                    .HasMaxLength(25);

                entity.Property(e => e.NationalStartDate).HasMaxLength(8);

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RowState)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:insert;1:insertAfterUpdte");

                entity.Property(e => e.SpouseBithDate).HasMaxLength(8);

                entity.Property(e => e.SpouseInsuranceExpiryDate).HasMaxLength(8);

                entity.Property(e => e.SpouseInsuranceIssueDate).HasMaxLength(8);

                entity.Property(e => e.SpouseInsuranceNo).HasMaxLength(25);

                entity.Property(e => e.SpouseNameArabic).HasMaxLength(200);

                entity.Property(e => e.SpouseNameEn).HasMaxLength(200);

                entity.Property(e => e.SpouseNationalityId)
                    .HasColumnName("SpouseNationality_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.SpousePassportExpiryDate).HasMaxLength(8);

                entity.Property(e => e.SpousePassportIssueDate).HasMaxLength(8);

                entity.Property(e => e.SpousePassportNo).HasMaxLength(25);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpTransferEmployeeRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpTransferEmployeeRecord_1");

                entity.ToTable("Hr_EmpTransferEmployeeRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrentAdminId)
                    .HasColumnName("CurrentAdmin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrentDeptId)
                    .HasColumnName("CurrentDept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.NewAdminId)
                    .HasColumnName("NewAdmin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.NewDeptId)
                    .HasColumnName("NewDept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpTransferEmployeeRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpTransferEmployeeRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpTransferEmployeeRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpTransferEmployeeRequest_1");

                entity.ToTable("Hr_EmpTransferEmployeeRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CurrentAdminId)
                    .HasColumnName("CurrentAdmin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CurrentDeptId)
                    .HasColumnName("CurrentDept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.NewAdminId)
                    .HasColumnName("NewAdmin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.NewDeptId)
                    .HasColumnName("NewDept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpTransferEmployeeRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpTransferEmployeeRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpTransferEmployeeRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpTransferEmployeeRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpTravelTickectRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpTravelTickectRecord_1");

                entity.ToTable("Hr_EmpTravelTickectRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ActuallValue)
                    .HasColumnName("Actuall_Value")
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AirPortCompany).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GoAmPm).HasMaxLength(1);

                entity.Property(e => e.GoDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ReserverdType)
                    .HasColumnName("Reserverd_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Reserved tickect;2:deliver cash");

                entity.Property(e => e.ReserverdValue)
                    .HasColumnName("Reserverd_Value")
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnAmPm).HasMaxLength(1);

                entity.Property(e => e.ReturnDate).HasMaxLength(8);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpTravelTickectRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpTravelTickectRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpTravelTickectRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpTravelTickectRequest_1");

                entity.ToTable("Hr_EmpTravelTickectRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActuallValue)
                    .HasColumnName("Actuall_Value")
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AirPortCompany).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GoAmPm).HasMaxLength(1);

                entity.Property(e => e.GoDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ReserverdType)
                    .HasColumnName("Reserverd_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Reserved tickect;2:deliver cash");

                entity.Property(e => e.ReserverdValue)
                    .HasColumnName("Reserverd_Value")
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnAmPm).HasMaxLength(1);

                entity.Property(e => e.ReturnDate).HasMaxLength(8);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpTravelTickectRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpTravelTickectRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpTravelTickectRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpTravelTickectRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpVactionOrder>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_EmpVactionOrder");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectEmpSerialNo)
                    .HasColumnName("DirectEmp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectManagerComment)
                    .HasColumnName("DirectManager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.HrManagerComment)
                    .HasColumnName("Hr_Manager_Comment")
                    .HasColumnType("text");

                entity.Property(e => e.HrManagerSerialNo)
                    .HasColumnName("Hr_Manager_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.VactionPeriod)
                    .HasColumnName("Vaction_Period")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.VactionTypeId).HasColumnName("VactionType_Id");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpVactionOrder)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpVactionOrder_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpVactionOrderHistory>(entity =>
            {
                entity.HasKey(e => e.HdrId);

                entity.ToTable("Hr_EmpVactionOrder_History");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserComment).HasColumnType("text");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<HrEmpVactionRecord>(entity =>
            {
                entity.HasKey(e => new { e.RecHdrId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_EmpVactionRecord_1");

                entity.ToTable("Hr_EmpVactionRecord");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AcuallBackDate).HasMaxLength(8);

                entity.Property(e => e.AcuallVactionPeiod)
                    .HasColumnName("AcuallVaction_Peiod")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BackDate).HasMaxLength(8);

                entity.Property(e => e.ChargeBalancRequest)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrAllowedVacTillDate)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrDiscTransferdPeriod)
                    .HasColumnName("Curr_DiscTransferd_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrDiscVacPeriod)
                    .HasColumnName("Curr_DiscVac_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FreeBalancRequest)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OfficalVactionPeriod)
                    .HasColumnName("Offical_Vaction_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlaceOfResidence).HasMaxLength(200);

                entity.Property(e => e.PrevVactionPeriod)
                    .HasColumnName("Prev_Vaction_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecOrderHdrId).HasColumnName("Rec_Order_HdrId");

                entity.Property(e => e.RecOrderNo)
                    .HasColumnName("Rec_Order_No")
                    .HasMaxLength(25)
                    .HasComment("This is the number of order");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.TotTransferdPeriod)
                    .HasColumnName("Tot_Transferd_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.VacPlaceType)
                    .HasColumnName("Vac_Place_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:Internal;2:Extrnal");

                entity.Property(e => e.VactionFromPrmEffec)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VactionPeriod)
                    .HasColumnName("Vaction_Period")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpVactionRecord)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpVactionRecord_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpVactionRequest>(entity =>
            {
                entity.HasKey(e => e.RecHdrId)
                    .HasName("PK_Hr_EmpVactionRequest_1");

                entity.ToTable("Hr_EmpVactionRequest");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BackDate).HasMaxLength(8);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ChargeBalancRequest)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurrAllowedVacTillDate)
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrDiscTransferdPeriod)
                    .HasColumnName("Curr_DiscTransferd_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrDiscVacPeriod)
                    .HasColumnName("Curr_DiscVac_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FreeBalancRequest)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OfficalVactionPeriod)
                    .HasColumnName("Offical_Vaction_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.PlaceOfResidence).HasMaxLength(200);

                entity.Property(e => e.PrevVactionPeriod)
                    .HasColumnName("Prev_Vaction_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecNo)
                    .HasColumnName("Rec_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ToDate).HasMaxLength(8);

                entity.Property(e => e.TotTransferdPeriod)
                    .HasColumnName("Tot_Transferd_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate).HasMaxLength(8);

                entity.Property(e => e.VacPlaceType)
                    .HasColumnName("Vac_Place_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((2))")
                    .HasComment("1:Internal;2:Extrnal");

                entity.Property(e => e.VactionFromPrmEffec)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VactionPeriod)
                    .HasColumnName("Vaction_Period")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HrEmployees)
                    .WithMany(p => p.HrEmpVactionRequest)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId, d.EmpSerialNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_EmpVactionRequest_Hr_Employees");
            });

            modelBuilder.Entity<HrEmpVactionRequestWorkFlow>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpVactionRequestWorkFlow");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("DtlsID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.EmpNameReplay).HasMaxLength(50);

                entity.Property(e => e.EmpReplay).HasComment("1:Yes;2:No");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo).HasMaxLength(25);

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:UnderCreate;2:Accept;3:Refuse;4:DataNotCompleted");

                entity.Property(e => e.RequestType).HasMaxLength(3);
            });

            modelBuilder.Entity<HrEmpWeekDaysDtls>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmpWeekDaysDtls");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DayTypeId).HasMaxLength(1);

                entity.Property(e => e.EmpHdrId).HasColumnName("Emp_Hdr_Id");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WeekSysDayId).HasMaxLength(1);
            });

            modelBuilder.Entity<HrEmployeeContractPeriods>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.ContractPeriodId });

                entity.ToTable("Hr_EmployeeContractPeriods");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromStartPeriod).HasMaxLength(8);

                entity.Property(e => e.Insdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastTransRecHdrId).HasColumnName("LastTransRec_hdr_Id");

                entity.Property(e => e.NoOfDeservedDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("");

                entity.Property(e => e.NoOfRestVacDays)
                    .HasColumnType("numeric(19, 0)")
                    .HasComputedColumnSql("([NoOfDeservedDays]-[NoOfVacDays])");

                entity.Property(e => e.NoOfVacDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToEndPeriod).HasMaxLength(8);

                entity.Property(e => e.WorkStartingDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmployeeContractPeriodsHistory>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.RowId });

                entity.ToTable("Hr_EmployeeContractPeriods_History");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.RowId)
                    .HasColumnName("Row_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodId)
                    .HasColumnName("ContractPeriod_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Insdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastTransRecHdrId).HasColumnName("LastTransRec_hdr_Id");

                entity.Property(e => e.LastTransRecHdrIdNew).HasColumnName("LastTransRec_hdr_IdNew");

                entity.Property(e => e.NoOfRestVacDays).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NoOfRestVacDaysNew)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HrEmployeeContractsDetails>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.ContractId })
                    .HasName("PK_Hr_EmployeeContractsDetails_1");

                entity.ToTable("Hr_EmployeeContractsDetails");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContractPeriodByMonth).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EndContract)
                    .HasColumnName("End_Contract")
                    .HasMaxLength(8);

                entity.Property(e => e.StartContract)
                    .HasColumnName("Start_Contract")
                    .HasMaxLength(8);

                entity.Property(e => e.WorkStartingDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.EmployeeStatusId);

                entity.ToTable("Hr_EmployeeStatus");

                entity.Property(e => e.EmployeeStatusId)
                    .HasColumnName("EmployeeStatus_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.EmployeeStatusName)
                    .IsRequired()
                    .HasColumnName("EmployeeStatus_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeStatusNameEn)
                    .HasColumnName("EmployeeStatus_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<HrEmployees>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.EmpSerialNo });

                entity.ToTable("Hr_Employees");

                entity.HasIndex(e => e.EmpCode)
                    .HasName("IX_Hr_Employees")
                    .IsUnique();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountBankNo1).HasMaxLength(25);

                entity.Property(e => e.AccountBankNo2).HasMaxLength(25);

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AttendanceType)
                    .HasColumnName("Attendance_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Shift;2:Attendance hours");

                entity.Property(e => e.BankNo1)
                    .HasColumnName("Bank_No1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BankNo2)
                    .HasColumnName("Bank_No2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("Birth_Place")
                    .HasMaxLength(100);

                entity.Property(e => e.BusinessEmail).HasMaxLength(50);

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractClassify)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1:Family;2:Single')");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractPeriodByMonth).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CounteryId)
                    .HasColumnName("Countery_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeductInsurance).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.DeliverSalType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:by bank ;2 :Cash");

                entity.Property(e => e.DeptId)
                    .HasColumnName("Dept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpFirstName)
                    .HasColumnName("Emp_First_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpFirstNameEn)
                    .HasColumnName("Emp_First_NameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpGrandFatherName)
                    .HasColumnName("Emp_GrandFatherName")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpGrandFatherNameEn)
                    .HasColumnName("Emp_GrandFatherNameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpLastName)
                    .HasColumnName("Emp_Last_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpLastNameConv).HasColumnName("Emp_Last_NameConv");

                entity.Property(e => e.EmpLastNameEn)
                    .HasColumnName("Emp_Last_NameEn")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpMeduimName)
                    .HasColumnName("Emp_Meduim_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpMeduimNameEn)
                    .HasColumnName("Emp_Meduim_NameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.EmpStatusId)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndContract).HasMaxLength(8);

                entity.Property(e => e.EnrollFpnumber)
                    .HasColumnName("EnrollFPNumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Fax).HasMaxLength(25);

                entity.Property(e => e.GenederId)
                    .HasColumnName("Geneder_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobId)
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.HasAbsence)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HasDelay)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HasFingerPrint)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HasManager)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0:no;1:yes");

                entity.Property(e => e.HasMedicalInsurance)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HasOverTime)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HasPermission)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:true;2:false");

                entity.Property(e => e.HireDate)
                    .HasColumnName("Hire_Date")
                    .HasMaxLength(8);

                entity.Property(e => e.IbanNo1)
                    .HasColumnName("IBAN_No1")
                    .HasMaxLength(25);

                entity.Property(e => e.IbanNo2)
                    .HasColumnName("IBAN_No2")
                    .HasMaxLength(25);

                entity.Property(e => e.IdentityEndDate)
                    .HasColumnName("Identity_EndDate")
                    .HasMaxLength(8);

                entity.Property(e => e.IdentityEndDateHijri)
                    .HasColumnName("Identity_EndDateHijri")
                    .HasMaxLength(8);

                entity.Property(e => e.IdentityNo)
                    .HasColumnName("Identity_No")
                    .HasMaxLength(25);

                entity.Property(e => e.IdentityStartDate)
                    .HasColumnName("Identity_StartDate")
                    .HasMaxLength(8);

                entity.Property(e => e.IdentityStartDateHijri)
                    .HasColumnName("Identity_StartDateHijri")
                    .HasMaxLength(8);

                entity.Property(e => e.IdentityTypeId)
                    .HasColumnName("Identity_Type_Id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Eqama;2:Identification");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InsideMobile1)
                    .HasColumnName("Inside_Mobile1")
                    .HasMaxLength(25);

                entity.Property(e => e.InsideMobile2)
                    .HasColumnName("Inside_Mobile2")
                    .HasMaxLength(25);

                entity.Property(e => e.InsidePhone)
                    .HasColumnName("Inside_Phone")
                    .HasMaxLength(25);

                entity.Property(e => e.IsCommissioner)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Commissioner");

                entity.Property(e => e.IsEmpManager)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:No;1:Yes");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobTitle).HasMaxLength(100);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.MedicalInsuranceEndDate)
                    .HasColumnName("Medical_Insurance_EndDate")
                    .HasMaxLength(8);

                entity.Property(e => e.MedicalInsuranceEndDateHijri)
                    .HasColumnName("Medical_Insurance_EndDateHijri")
                    .HasMaxLength(8);

                entity.Property(e => e.MedicalInsuranceNo)
                    .HasColumnName("Medical_Insurance_No")
                    .HasMaxLength(25);

                entity.Property(e => e.MedicalInsuranceStartDate)
                    .HasColumnName("Medical_Insurance_StartDate")
                    .HasMaxLength(8);

                entity.Property(e => e.MedicalInsuranceStartDateHijri)
                    .HasColumnName("Medical_Insurance_StartDateHijri")
                    .HasMaxLength(8);

                entity.Property(e => e.MilitaryStatusId)
                    .HasColumnName("Military_Status_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.NationalityId)
                    .HasColumnName("Nationality_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.NeedMandate)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:notNeed ; 1: need");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OutsideMobile1)
                    .HasColumnName("Outside_Mobile1")
                    .HasMaxLength(25);

                entity.Property(e => e.OutsideMobile2)
                    .HasColumnName("Outside_Mobile2")
                    .HasMaxLength(25);

                entity.Property(e => e.OutsidePhone1)
                    .HasColumnName("Outside_Phone1")
                    .HasMaxLength(25);

                entity.Property(e => e.PassportExpiryDate).HasMaxLength(8);

                entity.Property(e => e.PassportIssueDate).HasMaxLength(8);

                entity.Property(e => e.PassportNo).HasMaxLength(25);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateEmail).HasMaxLength(50);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.QualifyId)
                    .HasColumnName("Qualify_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.QualifyTypeId)
                    .HasColumnName("Qualify_Type_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ReligionId)
                    .HasColumnName("Religion_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.SocialInsuranceNo)
                    .HasColumnName("Social_Insurance_No")
                    .HasMaxLength(25);

                entity.Property(e => e.SocialStatusId)
                    .HasColumnName("Social_Status_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.StartContract).HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.WorkStartingDate).HasMaxLength(8);

                entity.Property(e => e.WorkStartingDateAfterRenwal).HasMaxLength(8);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Employees_Hr_Companies");

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Employees_Hr_Branches");
            });

            modelBuilder.Entity<HrEmployeesHistory>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmployeesHistory");

                entity.Property(e => e.RecId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AdminIdNew)
                    .HasColumnName("Admin_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CommissionerSerialNoNew)
                    .HasColumnName("Commissioner_Serial_noNew")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractClassify)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1:Family;2:Single')");

                entity.Property(e => e.ContractClassifyNew)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1:Family;2:Single')");

                entity.Property(e => e.ContractId)
                    .HasColumnName("Contract_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractIdNew)
                    .HasColumnName("Contract_IdNew")
                    .HasMaxLength(1);

                entity.Property(e => e.ContractPeriodByMonth).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContractPeriodByMonthNew).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeptId)
                    .HasColumnName("Dept_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeptIdNew)
                    .HasColumnName("Dept_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpStatusId)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpStatusIdNew)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndContract).HasMaxLength(8);

                entity.Property(e => e.EndContractNew).HasMaxLength(8);

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeIdNew)
                    .HasColumnName("Grade_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobId)
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobIdNew)
                    .HasColumnName("GradeJob_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransDate).HasColumnType("datetime");

                entity.Property(e => e.InsTransUser).HasMaxLength(100);

                entity.Property(e => e.InsUser).HasMaxLength(100);

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobIdNew)
                    .HasColumnName("Job_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.JobTitle).HasMaxLength(100);

                entity.Property(e => e.JobTitleNew).HasMaxLength(100);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ManagerIdNew)
                    .HasColumnName("Manager_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ProjectIdNew)
                    .HasColumnName("Project_IdNew")
                    .HasMaxLength(6);

                entity.Property(e => e.QualifyId)
                    .HasColumnName("Qualify_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.QualifyIdNew)
                    .HasColumnName("Qualify_IdNew")
                    .HasMaxLength(3);

                entity.Property(e => e.QualifyTypeId)
                    .HasColumnName("Qualify_Type_Id")
                    .HasMaxLength(1);

                entity.Property(e => e.QualifyTypeIdNew)
                    .HasColumnName("Qualify_Type_IdNew")
                    .HasMaxLength(1);

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecStatusNew)
                    .HasColumnName("Rec_StatusNew")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.ShiftIdNew)
                    .HasColumnName("Shift_IdNew")
                    .HasMaxLength(3);

                entity.Property(e => e.StartContract).HasMaxLength(8);

                entity.Property(e => e.StartContractNew).HasMaxLength(8);

                entity.Property(e => e.Transdate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrEmploymentExperinceRecord>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmploymentExperinceRecord");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ExperienceId)
                    .HasColumnName("Experience_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecHdrId).HasColumnName("Rec_Hdr_Id");
            });

            modelBuilder.Entity<HrEmploymentExperinceRequest>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmploymentExperinceRequest");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ExperienceId)
                    .HasColumnName("Experience_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecHdrId).HasColumnName("Rec_Hdr_Id");
            });

            modelBuilder.Entity<HrEmploymentQualifyRecord>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmploymentQualifyRecord");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.QualificationId)
                    .HasColumnName("Qualification_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.RecHdrId).HasColumnName("Rec_Hdr_Id");
            });

            modelBuilder.Entity<HrEmploymentQualifyRequest>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.RecId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_EmploymentQualifyRequest");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.QualificationId)
                    .HasColumnName("Qualification_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.RecHdrId).HasColumnName("Rec_Hdr_Id");
            });

            modelBuilder.Entity<HrExperienceCategories>(entity =>
            {
                entity.HasKey(e => e.ExperienceCategoryId);

                entity.ToTable("Hr_ExperienceCategories");

                entity.Property(e => e.ExperienceCategoryId)
                    .HasColumnName("ExperienceCategory_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.ExperienceCategoryCode)
                    .HasColumnName("ExperienceCategory_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceCategoryName)
                    .IsRequired()
                    .HasColumnName("ExperienceCategory_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExperienceCategoryNameConv).HasColumnName("ExperienceCategory_NameConv");

                entity.Property(e => e.ExperienceCategoryNameEn)
                    .HasColumnName("ExperienceCategory_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrExperiences>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("Hr_Experiences");

                entity.Property(e => e.ExperienceId)
                    .HasColumnName("Experience_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.ExperienceCategoryId)
                    .HasColumnName("ExperienceCategory_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceCode)
                    .HasColumnName("Experience_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.ExperienceName)
                    .HasColumnName("Experience_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExperienceNameConv).HasColumnName("Experience_NameConv");

                entity.Property(e => e.ExperienceNameEn)
                    .HasColumnName("Experience_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("Rec_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrFinalFingerPrint>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Hr_FinalFingerPrint");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DataInputType).HasComment("1:ByManually;2:FP;3:ForgetFP");

                entity.Property(e => e.DateTimeEnroll).HasMaxLength(50);

                entity.Property(e => e.DayNo).HasMaxLength(2);

                entity.Property(e => e.EnrollNumber).HasMaxLength(25);

                entity.Property(e => e.HourNo).HasMaxLength(2);

                entity.Property(e => e.InOutMode)
                    .HasMaxLength(1)
                    .HasComment("0:In;1:Out");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Irow)
                    .IsRequired()
                    .HasColumnName("IRow")
                    .HasMaxLength(15);

                entity.Property(e => e.MinuteNo).HasMaxLength(2);

                entity.Property(e => e.MonthNo).HasMaxLength(2);

                entity.Property(e => e.MonthYearNo).HasMaxLength(6);

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.Property(e => e.TmachineNumber)
                    .HasColumnName("TMachineNumber")
                    .HasMaxLength(6);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateFpstatus)
                    .HasColumnName("UpdateFPStatus")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotUpdate;1:Update");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.VerifyMode).HasMaxLength(6);

                entity.Property(e => e.YearNo).HasMaxLength(4);
            });

            modelBuilder.Entity<HrFingerPrint>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Hr_FingerPrint");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateTimeEnroll).HasMaxLength(50);

                entity.Property(e => e.DayNo).HasMaxLength(2);

                entity.Property(e => e.EnrollNumber).HasMaxLength(25);

                entity.Property(e => e.HourNo).HasMaxLength(2);

                entity.Property(e => e.InOutMode).HasMaxLength(1);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Irow)
                    .IsRequired()
                    .HasColumnName("IRow")
                    .HasMaxLength(15);

                entity.Property(e => e.MinuteNo).HasMaxLength(2);

                entity.Property(e => e.MonthNo).HasMaxLength(2);

                entity.Property(e => e.MonthYearNo).HasMaxLength(6);

                entity.Property(e => e.TmachineNumber)
                    .HasColumnName("TMachineNumber")
                    .HasMaxLength(6);

                entity.Property(e => e.VerifyMode).HasMaxLength(6);

                entity.Property(e => e.YearNo).HasMaxLength(4);
            });

            modelBuilder.Entity<HrFpmodeStatus>(entity =>
            {
                entity.HasKey(e => e.WeekSysDayId);

                entity.ToTable("Hr_FPModeStatus");

                entity.Property(e => e.WeekSysDayId).HasMaxLength(1);

                entity.Property(e => e.DefaultEffect)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotApply;1:Apply");

                entity.Property(e => e.EffectType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1:overtime;2:Discount;0:NoEffect");

                entity.Property(e => e.WeekSysDayName).HasMaxLength(20);

                entity.Property(e => e.WeekSysDayNameEn).HasMaxLength(20);
            });

            modelBuilder.Entity<HrGradeHiringItem>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_GradeHiringItem_1");

                entity.ToTable("Hr_GradeHiringItem");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeId)
                    .IsRequired()
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemValueType)
                    .HasColumnName("HireItem_Value_Type")
                    .HasComment("0:value;1:percentage");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");
            });

            modelBuilder.Entity<HrGradeHiringItemDtls>(entity =>
            {
                entity.HasKey(e => new { e.RecId, e.CompanyId, e.BranchId, e.GradeId, e.DtlsId });

                entity.ToTable("Hr_GradeHiringItem_Dtls");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemValueType)
                    .HasColumnName("HireItem_Value_Type")
                    .HasComment("0:value;1:percentage");
            });

            modelBuilder.Entity<HrGradeHiringItemFixed>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_GradeHiringItemFixed_1");

                entity.ToTable("Hr_GradeHiringItemFixed");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemValueType)
                    .HasColumnName("HireItem_Value_Type")
                    .HasComment("0:value;1:percentage");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");
            });

            modelBuilder.Entity<HrGradeHiringItemHdr>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.RecId, e.GradeId })
                    .HasName("PK_Hr_GradeHiringItem_Hdr_1");

                entity.ToTable("Hr_GradeHiringItem_Hdr");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrGradeJobGroups>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.GradeJobId });

                entity.ToTable("Hr_GradeJobGroups");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeJobId)
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.GradeJobAccountNo)
                    .HasColumnName("GradeJob_AccountNo")
                    .HasMaxLength(25);

                entity.Property(e => e.GradeJobCode)
                    .IsRequired()
                    .HasColumnName("GradeJob_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeJobName)
                    .IsRequired()
                    .HasColumnName("GradeJob_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeJobNameConv).HasColumnName("GradeJob_NameConv");

                entity.Property(e => e.GradeJobNameEn)
                    .IsRequired()
                    .HasColumnName("GradeJob_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrGradeJobGroups)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_GradeJobGroups_Hr_Branches");
            });

            modelBuilder.Entity<HrGradeVactionTicket>(entity =>
            {
                entity.HasKey(e => new { e.DtlsId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_GradeVactionTicket_1");

                entity.ToTable("Hr_GradeVactionTicket");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.GradeJobId)
                    .IsRequired()
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InternationalWorkTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LocalWorkTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.VactionPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VactionTicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.WorkingMonthNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("the no of Month that you are working to deserve the vacation");

                entity.Property(e => e.WorkingPeriodType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:ByYear;2:ByMonth");
            });

            modelBuilder.Entity<HrGrades>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("Hr_Grades");

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.GradeCode)
                    .HasColumnName("Grade_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasColumnName("Grade_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeNameConv).HasColumnName("Grade_NameConv");

                entity.Property(e => e.GradeNameEn)
                    .HasColumnName("Grade_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrHiringEmpDuesRequestEffect>(entity =>
            {
                entity.HasKey(e => e.RecHdrId);

                entity.ToTable("Hr_HiringEmpDuesRequestEffect");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.RequestDtlsId).HasColumnName("Request_Dtls_Id");

                entity.Property(e => e.RequestHdrId).HasColumnName("Request_Hdr_Id");

                entity.Property(e => e.TransDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrHiringEmpReceivableDuesDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_HiringEmpReceivableDues_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConfirmDate).HasMaxLength(8);

                entity.Property(e => e.Confirmed)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotConfirmed;1:Confirmed");

                entity.Property(e => e.ConfirmedUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueDate).HasMaxLength(8);

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.InsItemDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsItemUser).HasMaxLength(100);

                entity.Property(e => e.RecEmpDuesHdrId).HasColumnName("RecEmpDuesHdr_Id");

                entity.Property(e => e.RecRequestHdrId).HasColumnName("RecRequestHdr_Id");

                entity.Property(e => e.TransItemDate).HasMaxLength(8);

                entity.HasOne(d => d.Hdr)
                    .WithMany(p => p.HrHiringEmpReceivableDuesDtls)
                    .HasForeignKey(d => d.HdrId)
                    .HasConstraintName("FK_Hr_HiringEmpReceivableDues_Dtls_Hr_HiringEmpReceivableDues_Hdr");
            });

            modelBuilder.Entity<HrHiringEmpReceivableDuesHdr>(entity =>
            {
                entity.HasKey(e => e.HdrId);

                entity.ToTable("Hr_HiringEmpReceivableDues_Hdr");

                entity.Property(e => e.HdrId)
                    .HasColumnName("Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpRecStatus)
                    .HasColumnName("Emp_Rec_Status")
                    .HasComment("0:countinous;1:deleted");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpStatus)
                    .HasColumnName("Emp_Status")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .IsRequired()
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrHiringEmpSocialInsuranceEffect>(entity =>
            {
                entity.HasKey(e => e.RecHdrId);

                entity.ToTable("Hr_HiringEmpSocialInsuranceEffect");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.RequestDtlsId).HasColumnName("Request_Dtls_Id");

                entity.Property(e => e.RequestHdrId).HasColumnName("Request_Hdr_Id");

                entity.Property(e => e.TransDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrHiringItems>(entity =>
            {
                entity.HasKey(e => new { e.HireItemId, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_Hiring_Items");

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Constant;2:variable");

                entity.Property(e => e.AffectsSalaries)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Affect;2:Not Affect");

                entity.Property(e => e.CalcAnnually)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:NotCalcAnnual maybe monthly;1:CalcAnnually");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.HireAppearOnlyWGrades)
                    .HasColumnName("Hire_AppearOnlyW_Grades")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0:not;1:appear");

                entity.Property(e => e.HireAppearWGrade)
                    .HasColumnName("Hire_Appear_W_Grade")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0:not;1:appear");

                entity.Property(e => e.HireItemName)
                    .HasColumnName("HireItem_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.HireItemNameConv).HasColumnName("HireItem_NameConv");

                entity.Property(e => e.HireItemNameEn)
                    .HasColumnName("HireItem_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.HireStatus).HasColumnName("Hire_Status");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IsPaymentBorrow)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:no;1:yes");

                entity.Property(e => e.JoinEndOfService)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Not Join ; 1:Join to  calcEndOfService");

                entity.Property(e => e.NotIncludeVacAllownce)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Include;1:Not Include");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrHiringMonthActuallDuesDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_HiringMonth_ActuallDues_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HireItemActuallValue)
                    .HasColumnName("HireItem_ActuallValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.RecHdr)
                    .WithMany(p => p.HrHiringMonthActuallDuesDtls)
                    .HasForeignKey(d => d.RecHdrId)
                    .HasConstraintName("FK_Hr_HiringMonth_ActuallDues_Dtls_Hr_HiringMonth_ActuallDues_Hdr");
            });

            modelBuilder.Entity<HrHiringMonthActuallDuesHdr>(entity =>
            {
                entity.HasKey(e => e.RecHdrId);

                entity.ToTable("Hr_HiringMonth_ActuallDues_Hdr");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .IsRequired()
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrHiringMonthDelayDuesDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_HiringMonth_DelayDues_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HireItemDuesValue)
                    .HasColumnName("HireItem_DuesValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemStatus)
                    .HasColumnName("HireItem_Status")
                    .HasComment("0:NotPaid;1:Paid");

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.RecHdr)
                    .WithMany(p => p.HrHiringMonthDelayDuesDtls)
                    .HasForeignKey(d => d.RecHdrId)
                    .HasConstraintName("FK_Hr_HiringMonth_DelayDues_Dtls_Hr_HiringMonth_DelayDues_Hdr");
            });

            modelBuilder.Entity<HrHiringMonthDelayDuesHdr>(entity =>
            {
                entity.HasKey(e => e.RecHdrId);

                entity.ToTable("Hr_HiringMonth_DelayDues_Hdr");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .IsRequired()
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrHiringMonthFollowUpDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_HiringMonth_FollowUp_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HireItemActuallValue)
                    .HasColumnName("HireItem_ActuallValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemDiffValue)
                    .HasColumnName("HireItem_DiffValue")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemType)
                    .HasColumnName("HireItem_Type")
                    .HasComment("0:Dues;1:deduction");

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.RecEmpDuesHdrId).HasColumnName("RecEmpDuesHdr_Id");

                entity.Property(e => e.RecHdrId).HasColumnName("RecHdr_Id");

                entity.Property(e => e.RecRequestHdrId).HasColumnName("RecRequestHdr_Id");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.RecHdr)
                    .WithMany(p => p.HrHiringMonthFollowUpDtls)
                    .HasForeignKey(d => d.RecHdrId)
                    .HasConstraintName("FK_Hr_HiringMonth_FollowUp_Dtls_Hr_HiringMonth_FollowUp_Hdr");
            });

            modelBuilder.Entity<HrHiringMonthFollowUpHdr>(entity =>
            {
                entity.HasKey(e => e.RecHdrId);

                entity.ToTable("Hr_HiringMonth_FollowUp_Hdr");

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeliveredComplete).HasComment("0:complete;1:notcomplete");

                entity.Property(e => e.EmpRecStatus)
                    .HasColumnName("Emp_Rec_Status")
                    .HasComment("0:countinous;1:deleted");

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpStatus)
                    .HasColumnName("Emp_Status")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MonthNo)
                    .IsRequired()
                    .HasColumnName("Month_No")
                    .HasMaxLength(6);

                entity.Property(e => e.SalMonthStatus)
                    .HasColumnName("Sal_Month_Status")
                    .HasComment("0:Not;1:Etmad");

                entity.Property(e => e.TransDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrInporgressAndApprovedRequests>(entity =>
            {
                entity.ToTable("Hr_InporgressAndApprovedRequests");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromDate).HasMaxLength(8);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("Order_Status")
                    .HasMaxLength(1);

                entity.Property(e => e.RecHdrId)
                    .HasColumnName("Rec_Hdr_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestGroupTypeId)
                    .HasColumnName("RequestGroupType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.RequestId).HasMaxLength(3);

                entity.Property(e => e.ToDate).HasMaxLength(8);
            });

            modelBuilder.Entity<HrJobs>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.CompanyId, e.BranchId })
                    .HasName("PK_Hr_Jobs_1");

                entity.ToTable("Hr_Jobs");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.GradeJobId)
                    .HasColumnName("GradeJob_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.IsManager).HasComment("1:manager;0: other jobs");

                entity.Property(e => e.JobCode)
                    .HasColumnName("Job_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameConv).HasColumnName("Job_NameConv");

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrMilitaryStatuses>(entity =>
            {
                entity.HasKey(e => e.MilitaryStatusId);

                entity.ToTable("Hr_MilitaryStatuses");

                entity.Property(e => e.MilitaryStatusId)
                    .HasColumnName("MilitaryStatus_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.MilitaryStatusName)
                    .IsRequired()
                    .HasColumnName("MilitaryStatus_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.MilitaryStatusNameConv).HasColumnName("MilitaryStatus_NameConv");

                entity.Property(e => e.MilitaryStatusNameEn)
                    .HasColumnName("MilitaryStatus_NameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrNationalities>(entity =>
            {
                entity.HasKey(e => e.NationalityId);

                entity.ToTable("Hr_Nationalities");

                entity.Property(e => e.NationalityId)
                    .HasColumnName("Nationality_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("Nationality_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasColumnName("Nationality_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityNameConv).HasColumnName("Nationality_NameConv");

                entity.Property(e => e.NationalityNameEn)
                    .HasColumnName("Nationality_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrNotificationTypes>(entity =>
            {
                entity.HasKey(e => e.NotificationTypeId);

                entity.ToTable("Hr_Notification_Types");

                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("NotificationType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.NotificationTypeName)
                    .IsRequired()
                    .HasColumnName("NotificationType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.NotificationTypeNameEn)
                    .HasColumnName("NotificationType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<HrOfficialVacations>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_Official_Vacations");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DeductFromAnnualVac).HasComment("0:No;1:Yes deduct");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.VacDate)
                    .HasColumnName("Vac_date")
                    .HasMaxLength(8);

                entity.Property(e => e.VacDateHijri)
                    .HasColumnName("Vac_dateHijri")
                    .HasMaxLength(8);

                entity.Property(e => e.VacDayType)
                    .HasColumnName("Vac_Day_Type")
                    .HasMaxLength(1);

                entity.Property(e => e.VacationName)
                    .HasColumnName("Vacation_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.VacationNameEn)
                    .HasColumnName("Vacation_NameEn")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<HrOverTimeTypes>(entity =>
            {
                entity.HasKey(e => e.OverTimeTypeId);

                entity.ToTable("Hr_OverTime_Types");

                entity.Property(e => e.OverTimeTypeId).HasColumnName("OverTimeType_Id");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.OverTimeTypeName)
                    .IsRequired()
                    .HasColumnName("OverTimeType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OverTimeTypeNameConv).HasColumnName("OverTimeType_NameConv");

                entity.Property(e => e.OverTimeTypeNameEn)
                    .HasColumnName("OverTimeType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrPermissionReasons>(entity =>
            {
                entity.HasKey(e => e.PermissionReasonId);

                entity.ToTable("Hr_PermissionReasons");

                entity.Property(e => e.PermissionReasonId)
                    .HasColumnName("PermissionReason_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.PermissionReasonCode)
                    .HasColumnName("PermissionReason_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.PermissionReasonName)
                    .IsRequired()
                    .HasColumnName("PermissionReason_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionReasonNameConv).HasColumnName("PermissionReason_NameConv");

                entity.Property(e => e.PermissionReasonNameEn)
                    .HasColumnName("PermissionReason_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionType)
                    .HasColumnName("Permission_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Personal;2:JobMission");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrPermissionSubReasons>(entity =>
            {
                entity.HasKey(e => e.PermissionSubReasonId);

                entity.ToTable("Hr_PermissionSubReasons");

                entity.Property(e => e.PermissionSubReasonId)
                    .HasColumnName("PermissionSubReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.PermissionReasonId)
                    .IsRequired()
                    .HasColumnName("PermissionReason_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.PermissionSubReasonCode)
                    .HasColumnName("PermissionSubReason_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.PermissionSubReasonName)
                    .IsRequired()
                    .HasColumnName("PermissionSubReason_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionSubReasonNameConv).HasColumnName("PermissionSubReason_NameConv");

                entity.Property(e => e.PermissionSubReasonNameEn)
                    .HasColumnName("PermissionSubReason_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionType)
                    .HasColumnName("Permission_Type")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Personal;2:JobMission");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrPermissionTypes>(entity =>
            {
                entity.HasKey(e => e.PermissionTypeId);

                entity.ToTable("Hr_Permission_Types");

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionType_Id");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.PermissionTypeName)
                    .IsRequired()
                    .HasColumnName("PermissionType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionTypeNameConv).HasColumnName("PermissionType_NameConv");

                entity.Property(e => e.PermissionTypeNameEn)
                    .HasColumnName("PermissionType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrProjects>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.ProjectId });

                entity.ToTable("Hr_Projects");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("Project_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectNameConv).HasColumnName("Project_NameConv");

                entity.Property(e => e.ProjectNameEn)
                    .HasColumnName("Project_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrQualificationTypes>(entity =>
            {
                entity.HasKey(e => e.QualificationTypeId);

                entity.ToTable("Hr_QualificationTypes");

                entity.Property(e => e.QualificationTypeId)
                    .HasColumnName("QualificationType_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.QualificationTypeName)
                    .IsRequired()
                    .HasColumnName("QualificationType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationTypeNameConv).HasColumnName("QualificationType_NameConv");

                entity.Property(e => e.QualificationTypeNameEn)
                    .HasColumnName("QualificationType_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrQualifications>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.ToTable("Hr_Qualifications");

                entity.Property(e => e.QualificationId)
                    .HasColumnName("Qualification_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.QualificationCode)
                    .HasColumnName("Qualification_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.QualificationName)
                    .IsRequired()
                    .HasColumnName("Qualification_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationNameConv).HasColumnName("Qualification_NameConv");

                entity.Property(e => e.QualificationNameEn)
                    .HasColumnName("Qualification_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrReligions>(entity =>
            {
                entity.HasKey(e => e.ReligionId);

                entity.ToTable("Hr_Religions");

                entity.Property(e => e.ReligionId)
                    .HasColumnName("Religion_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("Religion_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.ReligionName)
                    .IsRequired()
                    .HasColumnName("Religion_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReligionNameConv).HasColumnName("Religion_NameConv");

                entity.Property(e => e.ReligionNameEn)
                    .HasColumnName("Religion_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrRequestGroupTypes>(entity =>
            {
                entity.HasKey(e => e.RequestGroupTypeId);

                entity.ToTable("Hr_RequestGroup_Types");

                entity.Property(e => e.RequestGroupTypeId)
                    .HasColumnName("RequestGroupType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestGroupTypeName)
                    .IsRequired()
                    .HasColumnName("RequestGroupType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestGroupTypeNameEn)
                    .HasColumnName("RequestGroupType_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HrRequestStatus>(entity =>
            {
                entity.HasKey(e => e.RequestStatusId);

                entity.ToTable("Hr_RequestStatus");

                entity.Property(e => e.RequestStatusId)
                    .HasColumnName("RequestStatus_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestStatusName)
                    .IsRequired()
                    .HasColumnName("RequestStatus_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestStatusNameEn)
                    .HasColumnName("RequestStatus_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HrRequestTypes>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.RequestId })
                    .HasName("PK_Hr_RequestTypes_1");

                entity.ToTable("Hr_RequestTypes");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.AttachIsNecessary).HasComment("0:NotNeed;1:Needed");

                entity.Property(e => e.ChkJoinHireItem)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Join;2:Not Join");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.HireItemId)
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestName)
                    .HasColumnName("Request_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestNameConv).HasColumnName("Request_NameConv");

                entity.Property(e => e.RequestNameEn)
                    .HasColumnName("Request_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:Default;1:Vaction");

                entity.Property(e => e.SendOnlyToManger).HasComment("0:false;1:true");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.VactionIndivisible).HasComment("0:false;1:true");
            });

            modelBuilder.Entity<HrRequestTypesDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("Hr_RequestTypesDtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RequestDiscountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:WithoutDiscount;2:WithDiscount");

                entity.Property(e => e.RequestRatioValue).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.RequestTypeId)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RequestTypeValue).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Value;2:Percentage");
            });

            modelBuilder.Entity<HrRewardReasons>(entity =>
            {
                entity.HasKey(e => e.RewardReasonId);

                entity.ToTable("Hr_RewardReasons");

                entity.Property(e => e.RewardReasonId)
                    .HasColumnName("RewardReason_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RewardReasonCode)
                    .HasColumnName("RewardReason_Code")
                    .HasMaxLength(6);

                entity.Property(e => e.RewardReasonName)
                    .IsRequired()
                    .HasColumnName("RewardReason_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RewardReasonNameConv).HasColumnName("RewardReason_NameConv");

                entity.Property(e => e.RewardReasonNameEn)
                    .HasColumnName("RewardReason_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrShiftGroups>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.ShiftGroupId });

                entity.ToTable("Hr_ShiftGroups");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ShiftGroupId)
                    .HasColumnName("ShiftGroup_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ShiftGroupName)
                    .IsRequired()
                    .HasColumnName("ShiftGroup_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ShiftGroupNameConv).HasColumnName("ShiftGroup_NameConv");

                entity.Property(e => e.ShiftGroupNameEn)
                    .IsRequired()
                    .HasColumnName("ShiftGroup_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.ShiftGroupShortName)
                    .IsRequired()
                    .HasColumnName("ShiftGroup_ShortName")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrShiftGroups)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_ShiftGroups_Hr_Branches");
            });

            modelBuilder.Entity<HrShiftWeekDaysDtls>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_ShiftWeekDaysDtls");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DayTypeId).HasMaxLength(1);

                entity.Property(e => e.ShiftHdrId).HasColumnName("Shift_Hdr_Id");

                entity.Property(e => e.WeekSysDayId).HasMaxLength(1);
            });

            modelBuilder.Entity<HrShifts>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.ShiftId });

                entity.ToTable("Hr_Shifts");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AllowedPeriodToCalcByMin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BreakDurationByMin)
                    .HasColumnName("Break_DurationByMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BreakFromTime)
                    .HasColumnName("BreakFrom_Time")
                    .HasMaxLength(4);

                entity.Property(e => e.BreakToTime)
                    .HasColumnName("BreakTo_Time")
                    .HasMaxLength(4);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.FromTime)
                    .HasColumnName("From_Time")
                    .HasMaxLength(4);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.ShiftDurationByMin)
                    .HasColumnName("Shift_DurationByMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ShiftGroupId)
                    .HasColumnName("ShiftGroup_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftHdrId).HasColumnName("Shift_Hdr_Id");

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasColumnName("Shift_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.ShiftNameConv).HasColumnName("Shift_NameConv");

                entity.Property(e => e.ShiftNameEn)
                    .HasColumnName("Shift_NameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.ShortName).HasMaxLength(15);

                entity.Property(e => e.ToTime)
                    .HasColumnName("To_Time")
                    .HasMaxLength(4);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.HrShifts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Shifts_Hr_Companies");

                entity.HasOne(d => d.HrBranches)
                    .WithMany(p => p.HrShifts)
                    .HasForeignKey(d => new { d.CompanyId, d.BranchId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hr_Shifts_Hr_Branches");
            });

            modelBuilder.Entity<HrShiftsDetails>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.DtlsId });

                entity.ToTable("Hr_Shifts_Details");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FromTime)
                    .HasColumnName("From_Time")
                    .HasMaxLength(4);

                entity.Property(e => e.PeriodName)
                    .HasColumnName("Period_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodNo)
                    .HasColumnName("Period_no")
                    .HasMaxLength(3);

                entity.Property(e => e.ShiftId)
                    .IsRequired()
                    .HasColumnName("Shift_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.ToTime)
                    .HasColumnName("To_Time")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<HrSocialInsuranceDeductionPercntgSa>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Hr_Social_InsuranceDeductionPercntg_SA");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DeductOnEmpOrComp)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:deduct On Company;2:deduct On Employee");

                entity.Property(e => e.DeductPercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpNationalTypeId)
                    .HasColumnName("EmpNational_TypeId")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:Saudi ;2 :Foreigner");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InsuranceTypeId)
                    .IsRequired()
                    .HasColumnName("Insurance_Type_Id")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<HrSocialInsuranceTypes>(entity =>
            {
                entity.HasKey(e => e.InsuranceTypeId);

                entity.ToTable("Hr_Social_InsuranceTypes");

                entity.Property(e => e.InsuranceTypeId)
                    .HasColumnName("Insurance_Type_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.DeductOnEmpOrComp)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:deduct On Company;2:deduct On Employee");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.InsuranceTypeName)
                    .IsRequired()
                    .HasColumnName("Insurance_Type_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceTypeNameEn)
                    .IsRequired()
                    .HasColumnName("Insurance_Type_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrSocialStatuses>(entity =>
            {
                entity.HasKey(e => e.SocialStatusId);

                entity.ToTable("Hr_SocialStatuses");

                entity.Property(e => e.SocialStatusId)
                    .HasColumnName("SocialStatus_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.SocialStatusName)
                    .IsRequired()
                    .HasColumnName("SocialStatus_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.SocialStatusNameConv).HasColumnName("SocialStatus_NameConv");

                entity.Property(e => e.SocialStatusNameEn)
                    .HasColumnName("SocialStatus_NameEn")
                    .HasMaxLength(25);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<HrTicketTypes>(entity =>
            {
                entity.HasKey(e => e.TicketTypeId);

                entity.ToTable("Hr_TicketTypes");

                entity.Property(e => e.TicketTypeId)
                    .HasColumnName("TicketType_Id")
                    .HasMaxLength(2);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.TicketTypeName)
                    .IsRequired()
                    .HasColumnName("TicketType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TicketTypeNameEn)
                    .HasColumnName("TicketType_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HrTimeAttendanceSetting>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_TimeAttendanceSetting");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CheckInCodeFrmFp).HasColumnName("Check_In_CodeFrmFP");

                entity.Property(e => e.CheckOutCodeFrmFp).HasColumnName("Check_Out_CodeFrmFP");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("Machine_No")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HrUsers>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BranchId, e.UserId });

                entity.ToTable("Hr_Users");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_Hr_Users");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.UserId).HasMaxLength(15);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FailedCount)
                    .HasColumnName("Failed_count")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatePassDate)
                    .HasColumnName("Last_update_pass_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.UserAdmin)
                    .IsRequired()
                    .HasColumnName("User_admin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0:User ; 1 :Admin");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<HrVactionTypes>(entity =>
            {
                entity.HasKey(e => e.VactionTypeId);

                entity.ToTable("Hr_Vaction_Types");

                entity.Property(e => e.VactionTypeId).HasColumnName("VactionType_Id");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.VactionTypeName)
                    .IsRequired()
                    .HasColumnName("VactionType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.VactionTypeNameConv).HasColumnName("VactionType_NameConv");

                entity.Property(e => e.VactionTypeNameEn)
                    .HasColumnName("VactionType_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HrWeekPolicySystem>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId, e.PolicyId });

                entity.ToTable("Hr_WeekPolicySystem");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.AllowedPeriodSysToCalcByMin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CalcFullDayIfWorkingexceedsTo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CalcHalfDayIfWorkingUpTo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FirstFpbeforeShiftByMin)
                    .HasColumnName("FirstFPBeforeShiftByMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LastFpafterShiftByMin)
                    .HasColumnName("LastFPAfterShiftByMin")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinMinuteWorkingFromWeekOff).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PartialDayBeginTime)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PartialDayEndTime)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Pdduration)
                    .HasColumnName("PDDuration")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PolicyName).HasMaxLength(100);

                entity.Property(e => e.PolicyNameEn).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.WeekDays).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.WeekStartOn).HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<HrWeekPolicySystemDaysDtls>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId, e.BranchId });

                entity.ToTable("Hr_WeekPolicySystemDaysDtls");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DayTypeId).HasMaxLength(1);

                entity.Property(e => e.WeekSysDayId).HasMaxLength(1);
            });

            modelBuilder.Entity<HrWeekSysDays>(entity =>
            {
                entity.HasKey(e => e.WeekSysDayId);

                entity.ToTable("Hr_WeekSysDays");

                entity.Property(e => e.WeekSysDayId).HasMaxLength(1);

                entity.Property(e => e.DayFirstInSqlCode).HasMaxLength(1);

                entity.Property(e => e.ShortName).HasMaxLength(6);

                entity.Property(e => e.WeekSysDayName).HasMaxLength(15);

                entity.Property(e => e.WeekSysDayNameEn).HasMaxLength(15);
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MenuNameEn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PathUrl).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<NewMenuNames>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.MenuNameEn).HasMaxLength(255);

                entity.Property(e => e.NewMenuName).HasMaxLength(255);

                entity.Property(e => e.NewMenuNameEn).HasMaxLength(255);
            });

            modelBuilder.Entity<TestFactoryFp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestFactoryFP");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Serial).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TransLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TxtEmployeeData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDateAm)
                    .HasColumnName("Finish Date (AM)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDateHijri)
                    .HasColumnName("Finish Date Hijri")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdentityId)
                    .HasColumnName("Identity Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasColumnName("Job ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VacationDays)
                    .HasColumnName("vacation days")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPages>(entity =>
            {
                entity.ToTable("User_Pages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_id")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<VwEmpAnnualLeavePlanRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpAnnualLeavePlanRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpBorrowDelayRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpBorrowDelayRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpBorrowRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpBorrowRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpDisciplinaryProcedureRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpDisciplinaryProcedureRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpDismissalRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpDismissalRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpEmploymentRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpEmploymentRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpJobMissionRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpJobMissionRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpOverTimeRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpOverTimeRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpPermissionRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpPermissionRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpResignationRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpResignationRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpRewardRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpRewardRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpSecondmentRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpSecondmentRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpTicketValueForAllEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpTicketValueForAllEmployee");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HireItemId)
                    .IsRequired()
                    .HasColumnName("HireItem_Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HireItemValue)
                    .HasColumnName("HireItem_Value")
                    .HasColumnType("numeric(18, 7)");
            });

            modelBuilder.Entity<VwEmpTransferEmployeeRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpTransferEmployeeRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpTravelTickectRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpTravelTickectRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpVactionRequestWorkFlowHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpVactionRequestWorkFlowHistory");

                entity.Property(e => e.AlternateEmpSerialNo)
                    .HasColumnName("Alternate_Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AlternateJobId)
                    .HasColumnName("Alternate_Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.AlternativeEmpName).HasColumnName("ALternativeEmpName");

                entity.Property(e => e.AlternativeEmpNameEn).HasColumnName("ALternativeEmpNameEn");

                entity.Property(e => e.AlternativeJoibName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AlternativeJoibNameEn).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmpVactionRequestWorkFlowHistoryOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEmpVactionRequestWorkFlowHistoryOld");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.DateReplay).HasColumnType("datetime");

                entity.Property(e => e.EmpComment).HasColumnType("text");

                entity.Property(e => e.HdrId).HasColumnName("Hdr_Id");

                entity.Property(e => e.JobId)
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxiumDateReplay).HasColumnType("datetime");

                entity.Property(e => e.RecieverArabicName).HasColumnName("Reciever_Arabic_Name");

                entity.Property(e => e.RecieverEnglishName).HasColumnName("Reciever_English_Name");

                entity.Property(e => e.RecieverImagePath).HasColumnName("Reciever_imagePath");

                entity.Property(e => e.RecieverSerialNo)
                    .HasColumnName("Reciever_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SenderImagePath).HasColumnName("Sender_imagePath");

                entity.Property(e => e.SenderSerialNo)
                    .HasColumnName("Sender_Serial_No")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<VwEmployeesCommissioner>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmployeesCommissioner");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CommissionerSerialNo)
                    .HasColumnName("Commissioner_Serial_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<VwInsertVactionRequestSteps>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInsertVactionRequestSteps");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkFlowName)
                    .HasColumnName("WorkFlow_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameEn)
                    .HasColumnName("WorkFlow_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwInsertVactionRequestStepsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInsertVactionRequestSteps_Old");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkFlowName)
                    .HasColumnName("WorkFlow_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameEn)
                    .HasColumnName("WorkFlow_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwInsertVactionRequestStepsWithBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInsertVactionRequestStepsWithBranch");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("Job_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobNameEn)
                    .HasColumnName("Job_NameEn")
                    .HasMaxLength(100);

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasColumnName("Request_Id")
                    .HasMaxLength(3);

                entity.Property(e => e.WorkFlowName)
                    .HasColumnName("WorkFlow_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameEn)
                    .HasColumnName("WorkFlow_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwManagerEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwManagerEmployee");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<VwManagerEmployeeWbranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwManagerEmployeeWBranch");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("Branch_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_Id")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpSerialNo)
                    .HasColumnName("Emp_Serial_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");
            });

            modelBuilder.Entity<VwWorkFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwWorkFlow");

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.WorkFlowId)
                    .IsRequired()
                    .HasColumnName("WorkFlow_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.WorkFlowName)
                    .HasColumnName("WorkFlow_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameEn)
                    .HasColumnName("WorkFlow_NameEn")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkFlowDtls>(entity =>
            {
                entity.HasKey(e => e.DtlsId);

                entity.ToTable("WorkFlow_Dtls");

                entity.Property(e => e.DtlsId)
                    .HasColumnName("Dtls_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("Job_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.WorkFlowId)
                    .IsRequired()
                    .HasColumnName("WorkFlow_Id")
                    .HasMaxLength(6);

                entity.HasOne(d => d.WorkFlow)
                    .WithMany(p => p.WorkFlowDtls)
                    .HasForeignKey(d => d.WorkFlowId)
                    .HasConstraintName("FK_WorkFlow_Dtls_WorkFlow_Hdr");
            });

            modelBuilder.Entity<WorkFlowHdr>(entity =>
            {
                entity.HasKey(e => e.WorkFlowId);

                entity.ToTable("WorkFlow_Hdr");

                entity.Property(e => e.WorkFlowId)
                    .HasColumnName("WorkFlow_Id")
                    .HasMaxLength(6);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Test')");

                entity.Property(e => e.RecId)
                    .HasColumnName("Rec_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecStatus).HasColumnName("Rec_Status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(100);

                entity.Property(e => e.WorkFlowName)
                    .HasColumnName("WorkFlow_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameConv)
                    .HasColumnName("WorkFlow_NameConv")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkFlowNameEn)
                    .HasColumnName("WorkFlow_NameEn")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
