namespace TMS_New.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=MasterConnectionString")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccType> AccTypes { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<Adjustment> Adjustments { get; set; }
        public virtual DbSet<AdjustmentType> AdjustmentTypes { get; set; }
        public virtual DbSet<AdminTool_Module> AdminTool_Module { get; set; }
        public virtual DbSet<AdminTool_Page> AdminTool_Page { get; set; }
        public virtual DbSet<AdminTool_Premission> AdminTool_Premission { get; set; }
        public virtual DbSet<AdminTool_RolePage> AdminTool_RolePage { get; set; }
        public virtual DbSet<AdminTool_UserCategory> AdminTool_UserCategory { get; set; }
        public virtual DbSet<AdminTool_UserInRole> AdminTool_UserInRole { get; set; }
        public virtual DbSet<AdminTool_UserRole> AdminTool_UserRole { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<AttachedFile> AttachedFiles { get; set; }
        public virtual DbSet<AuditActionType> AuditActionTypes { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<Battery> Batteries { get; set; }
        public virtual DbSet<BatteryAssignment> BatteryAssignments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CalculationType> CalculationTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CheckingTransactionStatu> CheckingTransactionStatus { get; set; }
        public virtual DbSet<CheckInOutTransaction> CheckInOutTransactions { get; set; }
        public virtual DbSet<CheckInOutTransaction_AttachedFile> CheckInOutTransaction_AttachedFile { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ComboItem> ComboItems { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<CountProduct> CountProducts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryTrafficCode> CountryTrafficCodes { get; set; }
        public virtual DbSet<CountStock> CountStocks { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomNotificationLog> CustomNotificationLogs { get; set; }
        public virtual DbSet<DailyMailLogger> DailyMailLoggers { get; set; }
        public virtual DbSet<DailyMileageLog> DailyMileageLogs { get; set; }
        public virtual DbSet<DailyMileageLogForTrace> DailyMileageLogForTraces { get; set; }
        public virtual DbSet<DeliveryOrder> DeliveryOrders { get; set; }
        public virtual DbSet<DeliveryOrderDetail> DeliveryOrderDetails { get; set; }
        public virtual DbSet<DeliveryStatu> DeliveryStatus { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<DistributorBalanceHistory> DistributorBalanceHistories { get; set; }
        public virtual DbSet<DriverLicenseType> DriverLicenseTypes { get; set; }
        public virtual DbSet<DriversFine> DriversFines { get; set; }
        public virtual DbSet<DynamicAttributeType> DynamicAttributeTypes { get; set; }
        public virtual DbSet<EmailVerifier> EmailVerifiers { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<FuelLevel> FuelLevels { get; set; }
        public virtual DbSet<FuelLog> FuelLogs { get; set; }
        public virtual DbSet<GeofensesLandmarksLog> GeofensesLandmarksLogs { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<IButtonTable> IButtonTables { get; set; }
        public virtual DbSet<InspectionDetail> InspectionDetails { get; set; }
        public virtual DbSet<Insurance_Companies> Insurance_Companies { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Landmark> Landmarks { get; set; }
        public virtual DbSet<LandmarkDynamicAttributeMap> LandmarkDynamicAttributeMaps { get; set; }
        public virtual DbSet<LandmarksLoadsDetail> LandmarksLoadsDetails { get; set; }
        public virtual DbSet<LandmarkType> LandmarkTypes { get; set; }
        public virtual DbSet<LandmarkTypeMap> LandmarkTypeMaps { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LoggingLog> LoggingLogs { get; set; }
        public virtual DbSet<Lookup_TransporterSpecs> Lookup_TransporterSpecs { get; set; }
        public virtual DbSet<MailAction> MailActions { get; set; }
        public virtual DbSet<MailActions_Users> MailActions_Users { get; set; }
        public virtual DbSet<MainMenu> MainMenus { get; set; }
        public virtual DbSet<MaintenaceProblemSparPartsAssign> MaintenaceProblemSparPartsAssigns { get; set; }
        public virtual DbSet<Maintenance_VendorBranch> Maintenance_VendorBranch { get; set; }
        public virtual DbSet<Maintenance_Vendors> Maintenance_Vendors { get; set; }
        public virtual DbSet<MaintenanceDelayReason> MaintenanceDelayReasons { get; set; }
        public virtual DbSet<MaintenanceDriverRole> MaintenanceDriverRoles { get; set; }
        public virtual DbSet<MaintenancePM> MaintenancePMs { get; set; }
        public virtual DbSet<MaintenancePMPriority> MaintenancePMPriorities { get; set; }
        public virtual DbSet<MaintenancePMSetupTransporter> MaintenancePMSetupTransporters { get; set; }
        public virtual DbSet<MaintenancePMSetupTransporter_Log> MaintenancePMSetupTransporter_Log { get; set; }
        public virtual DbSet<MaintenancePMTask> MaintenancePMTasks { get; set; }
        public virtual DbSet<MaintenancePMTransporter> MaintenancePMTransporters { get; set; }
        public virtual DbSet<MaintenancePMTransporterBrand> MaintenancePMTransporterBrands { get; set; }
        public virtual DbSet<MaintenancePMTransporterManufacturer> MaintenancePMTransporterManufacturers { get; set; }
        public virtual DbSet<MaintenancePMTransporterType> MaintenancePMTransporterTypes { get; set; }
        public virtual DbSet<MaintenancePrefixTire> MaintenancePrefixTires { get; set; }
        public virtual DbSet<MaintenanceProblemDelayReason> MaintenanceProblemDelayReasons { get; set; }
        public virtual DbSet<MaintenanceProblemDiscussion> MaintenanceProblemDiscussions { get; set; }
        public virtual DbSet<MaintenanceSparePart> MaintenanceSpareParts { get; set; }
        public virtual DbSet<MaintenanceTireAttachement> MaintenanceTireAttachements { get; set; }
        public virtual DbSet<MaintenanceTireBrand> MaintenanceTireBrands { get; set; }
        public virtual DbSet<MaintenanceTireManfacturer> MaintenanceTireManfacturers { get; set; }
        public virtual DbSet<MaintenanceTireSize> MaintenanceTireSizes { get; set; }
        public virtual DbSet<MaintenanceTireTreadDepth> MaintenanceTireTreadDepths { get; set; }
        public virtual DbSet<MaintenanceTireType> MaintenanceTireTypes { get; set; }
        public virtual DbSet<MaintenanceTireUseType> MaintenanceTireUseTypes { get; set; }
        public virtual DbSet<MaintenanceTireVendor> MaintenanceTireVendors { get; set; }
        public virtual DbSet<MaintenanceWorkOrder> MaintenanceWorkOrders { get; set; }
        public virtual DbSet<MaintenanceWorkOrderAttachement> MaintenanceWorkOrderAttachements { get; set; }
        public virtual DbSet<MaintenanceWorkOrderPriority> MaintenanceWorkOrderPriorities { get; set; }
        public virtual DbSet<MaintenanceWorkorderStatusLog> MaintenanceWorkorderStatusLogs { get; set; }
        public virtual DbSet<MaintenanceWorkOrderType> MaintenanceWorkOrderTypes { get; set; }
        public virtual DbSet<MaintenanceWorkOrderVendor> MaintenanceWorkOrderVendors { get; set; }
        public virtual DbSet<MappedIntegrationCost> MappedIntegrationCosts { get; set; }
        public virtual DbSet<MobileGroup> MobileGroups { get; set; }
        public virtual DbSet<MobileToken> MobileTokens { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Module1> Modules1 { get; set; }
        public virtual DbSet<NotificationConfiguration> NotificationConfigurations { get; set; }
        public virtual DbSet<NotificationConfiguration_Customer> NotificationConfiguration_Customer { get; set; }
        public virtual DbSet<NotificationConfiguration_Groups> NotificationConfiguration_Groups { get; set; }
        public virtual DbSet<NotificationConfiguration_LandMarks> NotificationConfiguration_LandMarks { get; set; }
        public virtual DbSet<NotificationConfiguration_Staff> NotificationConfiguration_Staff { get; set; }
        public virtual DbSet<NotificationConfiguration_SubBranch> NotificationConfiguration_SubBranch { get; set; }
        public virtual DbSet<NotificationConfiguration_TransporterTypes> NotificationConfiguration_TransporterTypes { get; set; }
        public virtual DbSet<NotificationInbox> NotificationInboxes { get; set; }
        public virtual DbSet<NotificationInbox_EmailLog> NotificationInbox_EmailLog { get; set; }
        public virtual DbSet<NotificationInbox_InSystemLog> NotificationInbox_InSystemLog { get; set; }
        public virtual DbSet<NotificationInbox_SMSLog> NotificationInbox_SMSLog { get; set; }
        public virtual DbSet<NotificationsConfiguration_NotificationsRelatedTo> NotificationsConfiguration_NotificationsRelatedTo { get; set; }
        public virtual DbSet<NotificationsFor> NotificationsFors { get; set; }
        public virtual DbSet<NotificationsRelatedTo> NotificationsRelatedToes { get; set; }
        public virtual DbSet<NWC_Accessory> NWC_Accessory { get; set; }
        public virtual DbSet<NWC_ActionLogType> NWC_ActionLogType { get; set; }
        public virtual DbSet<NWC_BalanceUnit> NWC_BalanceUnit { get; set; }
        public virtual DbSet<NWC_BranchSetting> NWC_BranchSetting { get; set; }
        public virtual DbSet<NWC_ComplaintCategory> NWC_ComplaintCategory { get; set; }
        public virtual DbSet<NWC_ComplaintPriority> NWC_ComplaintPriority { get; set; }
        public virtual DbSet<NWC_ComplaintStatus> NWC_ComplaintStatus { get; set; }
        public virtual DbSet<NWC_ContactPerson> NWC_ContactPerson { get; set; }
        public virtual DbSet<NWC_Contract> NWC_Contract { get; set; }
        public virtual DbSet<NWC_ContractAccessory> NWC_ContractAccessory { get; set; }
        public virtual DbSet<NWC_ContractAttachment> NWC_ContractAttachment { get; set; }
        public virtual DbSet<NWC_Contractor> NWC_Contractor { get; set; }
        public virtual DbSet<NWC_ContractorAttachment> NWC_ContractorAttachment { get; set; }
        public virtual DbSet<NWC_ContractPrice> NWC_ContractPrice { get; set; }
        public virtual DbSet<NWC_ContractStations> NWC_ContractStations { get; set; }
        public virtual DbSet<NWC_ContractStationViolation> NWC_ContractStationViolation { get; set; }
        public virtual DbSet<NWC_ContractStatus> NWC_ContractStatus { get; set; }
        public virtual DbSet<NWC_ContractTariff> NWC_ContractTariff { get; set; }
        public virtual DbSet<NWC_ContractTerminationReason> NWC_ContractTerminationReason { get; set; }
        public virtual DbSet<NWC_ContractTerms> NWC_ContractTerms { get; set; }
        public virtual DbSet<NWC_ContractType> NWC_ContractType { get; set; }
        public virtual DbSet<NWC_Customer> NWC_Customer { get; set; }
        public virtual DbSet<NWC_CustomerAccount> NWC_CustomerAccount { get; set; }
        public virtual DbSet<NWC_CustomerLocation> NWC_CustomerLocation { get; set; }
        public virtual DbSet<NWC_CustomerLocationBalance> NWC_CustomerLocationBalance { get; set; }
        public virtual DbSet<NWC_CustomerLocationCategory> NWC_CustomerLocationCategory { get; set; }
        public virtual DbSet<NWC_CustomerLocationClass> NWC_CustomerLocationClass { get; set; }
        public virtual DbSet<NWC_CustomerLocationPriority> NWC_CustomerLocationPriority { get; set; }
        public virtual DbSet<NWC_CustomerLocationStatus> NWC_CustomerLocationStatus { get; set; }
        public virtual DbSet<NWC_CustomerSMS> NWC_CustomerSMS { get; set; }
        public virtual DbSet<NWC_DeassignReason> NWC_DeassignReason { get; set; }
        public virtual DbSet<NWC_DefaultTankerSize> NWC_DefaultTankerSize { get; set; }
        public virtual DbSet<NWC_DeferredWorkOrder> NWC_DeferredWorkOrder { get; set; }
        public virtual DbSet<NWC_DeferredWorkOrderStatus> NWC_DeferredWorkOrderStatus { get; set; }
        public virtual DbSet<NWC_DeviceMeter> NWC_DeviceMeter { get; set; }
        public virtual DbSet<NWC_DeviceMeterReading> NWC_DeviceMeterReading { get; set; }
        public virtual DbSet<NWC_DriverSMS> NWC_DriverSMS { get; set; }
        public virtual DbSet<NWC_EventType> NWC_EventType { get; set; }
        public virtual DbSet<NWC_EventWorkOrder> NWC_EventWorkOrder { get; set; }
        public virtual DbSet<NWC_Int_ObjectLog> NWC_Int_ObjectLog { get; set; }
        public virtual DbSet<NWC_Int_ObjectLogDTO> NWC_Int_ObjectLogDTO { get; set; }
        public virtual DbSet<NWC_Int_ObjectStatus> NWC_Int_ObjectStatus { get; set; }
        public virtual DbSet<NWC_PaymentType> NWC_PaymentType { get; set; }
        public virtual DbSet<NWC_PersonalIDType> NWC_PersonalIDType { get; set; }
        public virtual DbSet<NWC_RestrictedZoneVehicleType> NWC_RestrictedZoneVehicleType { get; set; }
        public virtual DbSet<NWC_ServiceType> NWC_ServiceType { get; set; }
        public virtual DbSet<NWC_SoqyaSchedules> NWC_SoqyaSchedules { get; set; }
        public virtual DbSet<NWC_StateWorkOrder> NWC_StateWorkOrder { get; set; }
        public virtual DbSet<NWC_StationCustomerLocationClass> NWC_StationCustomerLocationClass { get; set; }
        public virtual DbSet<NWC_StationOwnership> NWC_StationOwnership { get; set; }
        public virtual DbSet<NWC_StationServiceType> NWC_StationServiceType { get; set; }
        public virtual DbSet<NWC_StationStatus> NWC_StationStatus { get; set; }
        public virtual DbSet<NWC_StationWaterSource> NWC_StationWaterSource { get; set; }
        public virtual DbSet<NWC_StatusReason> NWC_StatusReason { get; set; }
        public virtual DbSet<NWC_TanckerCapacity> NWC_TanckerCapacity { get; set; }
        public virtual DbSet<NWC_TermsCategory> NWC_TermsCategory { get; set; }
        public virtual DbSet<NWC_TermsValueUnits> NWC_TermsValueUnits { get; set; }
        public virtual DbSet<NWC_UserLandmarkPermission> NWC_UserLandmarkPermission { get; set; }
        public virtual DbSet<NWC_UserServicePermission> NWC_UserServicePermission { get; set; }
        public virtual DbSet<NWC_VehicleAccessory> NWC_VehicleAccessory { get; set; }
        public virtual DbSet<NWC_VehicleCustomerLocationClass> NWC_VehicleCustomerLocationClass { get; set; }
        public virtual DbSet<NWC_VehicleLog> NWC_VehicleLog { get; set; }
        public virtual DbSet<NWC_VehicleLogType> NWC_VehicleLogType { get; set; }
        public virtual DbSet<NWC_ViolationPaymentStatus> NWC_ViolationPaymentStatus { get; set; }
        public virtual DbSet<NWC_WorkOrderAccessory> NWC_WorkOrderAccessory { get; set; }
        public virtual DbSet<NWC_WorkOrderComment> NWC_WorkOrderComment { get; set; }
        public virtual DbSet<NWC_WorkOrderComplaint> NWC_WorkOrderComplaint { get; set; }
        public virtual DbSet<NWC_WorkOrderInvoiceStatus> NWC_WorkOrderInvoiceStatus { get; set; }
        public virtual DbSet<NWC_WorkOrderLog> NWC_WorkOrderLog { get; set; }
        public virtual DbSet<NWC_WorkOrderPlannedRout> NWC_WorkOrderPlannedRout { get; set; }
        public virtual DbSet<NWC_WorkOrderTransaction> NWC_WorkOrderTransaction { get; set; }
        public virtual DbSet<NWC_Zone> NWC_Zone { get; set; }
        public virtual DbSet<NWC_ZoneNEWDATA> NWC_ZoneNEWDATA { get; set; }
        public virtual DbSet<NWC_ZoneStations> NWC_ZoneStations { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Offer_Module> Offer_Module { get; set; }
        public virtual DbSet<OperationContract> OperationContracts { get; set; }
        public virtual DbSet<OperationCost> OperationCosts { get; set; }
        public virtual DbSet<OperationLoad> OperationLoads { get; set; }
        public virtual DbSet<OperationLoadsAmountUnit> OperationLoadsAmountUnits { get; set; }
        public virtual DbSet<OperationLogs_Drugs> OperationLogs_Drugs { get; set; }
        public virtual DbSet<OperationLogs_DuringTransport> OperationLogs_DuringTransport { get; set; }
        public virtual DbSet<OperationLogs_NeonatalServices> OperationLogs_NeonatalServices { get; set; }
        public virtual DbSet<OperationProjectLoad> OperationProjectLoads { get; set; }
        public virtual DbSet<OperationsProject> OperationsProjects { get; set; }
        public virtual DbSet<OperationWorkOrder> OperationWorkOrders { get; set; }
        public virtual DbSet<OperationWorkOrderLandmark> OperationWorkOrderLandmarks { get; set; }
        public virtual DbSet<OperationWorkOrderStatu> OperationWorkOrderStatus { get; set; }
        public virtual DbSet<OperationWorkorderStuff> OperationWorkorderStuffs { get; set; }
        public virtual DbSet<OperationWorkOrderType> OperationWorkOrderTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Packing> Packings { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Path> Paths { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }
        public virtual DbSet<PriceGroup> PriceGroups { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<PriceType> PriceTypes { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<ProblemCategory> ProblemCategories { get; set; }
        public virtual DbSet<ProblemSeverity> ProblemSeverities { get; set; }
        public virtual DbSet<ProblemStatusLog> ProblemStatusLogs { get; set; }
        public virtual DbSet<ProblemType> ProblemTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectMailRecipient> ProjectMailRecipients { get; set; }
        public virtual DbSet<Project1> Projects1 { get; set; }
        public virtual DbSet<ProjectTransporterMaintenance> ProjectTransporterMaintenances { get; set; }
        public virtual DbSet<ProjectWorkOrder> ProjectWorkOrders { get; set; }
        public virtual DbSet<PS_Cancellation_Reason> PS_Cancellation_Reason { get; set; }
        public virtual DbSet<PS_EmptyTemplateSerials> PS_EmptyTemplateSerials { get; set; }
        public virtual DbSet<PS_LoadType> PS_LoadType { get; set; }
        public virtual DbSet<PS_OperationWorkOrder> PS_OperationWorkOrder { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_Landmark> PS_OperationWorkOrder_Landmark { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_LoadType> PS_OperationWorkOrder_LoadType { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_Resources> PS_OperationWorkOrder_Resources { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_ResourceType> PS_OperationWorkOrder_ResourceType { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_Status> PS_OperationWorkOrder_Status { get; set; }
        public virtual DbSet<PS_OperationWorkOrder_StatusLog> PS_OperationWorkOrder_StatusLog { get; set; }
        public virtual DbSet<PS_OperationWorkOrderCodeSerial> PS_OperationWorkOrderCodeSerial { get; set; }
        public virtual DbSet<PS_OperationWorkOrderLocationHistory> PS_OperationWorkOrderLocationHistory { get; set; }
        public virtual DbSet<PS_OperationWorkOrderLocationHistoryAction> PS_OperationWorkOrderLocationHistoryAction { get; set; }
        public virtual DbSet<PS_OperationWorkOrderType> PS_OperationWorkOrderType { get; set; }
        public virtual DbSet<PS_Route> PS_Route { get; set; }
        public virtual DbSet<PS_Route_Landmark> PS_Route_Landmark { get; set; }
        public virtual DbSet<PS_UnitType> PS_UnitType { get; set; }
        public virtual DbSet<PS_WorkOrder_Landmark_LoadType> PS_WorkOrder_Landmark_LoadType { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportsPage> ReportsPages { get; set; }
        public virtual DbSet<ReportSubscription> ReportSubscriptions { get; set; }
        public virtual DbSet<ReportSubscriptionUser> ReportSubscriptionUsers { get; set; }
        public virtual DbSet<RequestForRepair> RequestForRepairs { get; set; }
        public virtual DbSet<RequestForRepairAttachement> RequestForRepairAttachements { get; set; }
        public virtual DbSet<RequestForRepairStatusLog> RequestForRepairStatusLogs { get; set; }
        public virtual DbSet<Reseller> Resellers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<SaleOrder> SaleOrders { get; set; }
        public virtual DbSet<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual DbSet<ScannedFile> ScannedFiles { get; set; }
        public virtual DbSet<SCO_AbsencePlan> SCO_AbsencePlan { get; set; }
        public virtual DbSet<SCO_AbsencePlanStudent> SCO_AbsencePlanStudent { get; set; }
        public virtual DbSet<SCO_Class> SCO_Class { get; set; }
        public virtual DbSet<SCO_DailyTrip> SCO_DailyTrip { get; set; }
        public virtual DbSet<SCO_DailyTripStudents> SCO_DailyTripStudents { get; set; }
        public virtual DbSet<SCO_Gender> SCO_Gender { get; set; }
        public virtual DbSet<SCO_Grade> SCO_Grade { get; set; }
        public virtual DbSet<SCO_GuardianAttachments> SCO_GuardianAttachments { get; set; }
        public virtual DbSet<SCO_Guardians> SCO_Guardians { get; set; }
        public virtual DbSet<SCO_Holidays> SCO_Holidays { get; set; }
        public virtual DbSet<SCO_IdentityType> SCO_IdentityType { get; set; }
        public virtual DbSet<SCO_Notifications> SCO_Notifications { get; set; }
        public virtual DbSet<SCO_NotificationsTypes> SCO_NotificationsTypes { get; set; }
        public virtual DbSet<SCO_Plan> SCO_Plan { get; set; }
        public virtual DbSet<SCO_PlanAttachments> SCO_PlanAttachments { get; set; }
        public virtual DbSet<SCO_PlannedTrip> SCO_PlannedTrip { get; set; }
        public virtual DbSet<SCO_PlannedTripStudents> SCO_PlannedTripStudents { get; set; }
        public virtual DbSet<SCO_PlanType> SCO_PlanType { get; set; }
        public virtual DbSet<SCO_POI> SCO_POI { get; set; }
        public virtual DbSet<SCO_POIType> SCO_POIType { get; set; }
        public virtual DbSet<SCO_RelativeRelations> SCO_RelativeRelations { get; set; }
        public virtual DbSet<SCO_StudentAttachments> SCO_StudentAttachments { get; set; }
        public virtual DbSet<SCO_StudentGuardianRelation> SCO_StudentGuardianRelation { get; set; }
        public virtual DbSet<SCO_Students> SCO_Students { get; set; }
        public virtual DbSet<SCO_StudentTripStatus> SCO_StudentTripStatus { get; set; }
        public virtual DbSet<SCO_TripStatus> SCO_TripStatus { get; set; }
        public virtual DbSet<Service_Pages> Service_Pages { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<ShiftRule> ShiftRules { get; set; }
        public virtual DbSet<SLADurationType> SLADurationTypes { get; set; }
        public virtual DbSet<SLReferenceFormat> SLReferenceFormats { get; set; }
        public virtual DbSet<SparePartCategory> SparePartCategories { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_Attachments> Staff_Attachments { get; set; }
        public virtual DbSet<Staff_StaffGroups> Staff_StaffGroups { get; set; }
        public virtual DbSet<StaffActivity> StaffActivities { get; set; }
        public virtual DbSet<StaffDynamicAttributeMap> StaffDynamicAttributeMaps { get; set; }
        public virtual DbSet<StaffGroup> StaffGroups { get; set; }
        public virtual DbSet<StaffRoleCategory> StaffRoleCategories { get; set; }
        public virtual DbSet<StaffRoleDynamicAttributesMap> StaffRoleDynamicAttributesMaps { get; set; }
        public virtual DbSet<StaffRoleModulePermission> StaffRoleModulePermissions { get; set; }
        public virtual DbSet<StaffRole> StaffRoles { get; set; }
        public virtual DbSet<StaffShift> StaffShifts { get; set; }
        public virtual DbSet<StakeholderBarcode> StakeholderBarcodes { get; set; }
        public virtual DbSet<StockOnHand> StockOnHands { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<SubMenu> SubMenus { get; set; }
        public virtual DbSet<SubProblemType> SubProblemTypes { get; set; }
        public virtual DbSet<SubProblemTypesNotification> SubProblemTypesNotifications { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<SubscriberAdminSetting> SubscriberAdminSettings { get; set; }
        public virtual DbSet<SubscriberDisabledReport> SubscriberDisabledReports { get; set; }
        public virtual DbSet<SubscriberLog> SubscriberLogs { get; set; }
        public virtual DbSet<SubscriberTopUp> SubscriberTopUps { get; set; }
        public virtual DbSet<SubscriptionActivityLog> SubscriptionActivityLogs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierInfo> SupplierInfoes { get; set; }
        public virtual DbSet<SupplierSuggestion> SupplierSuggestions { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<Template_Parameters> Template_Parameters { get; set; }
        public virtual DbSet<TireAssignment> TireAssignments { get; set; }
        public virtual DbSet<Tire> Tires { get; set; }
        public virtual DbSet<TireSize> TireSizes { get; set; }
        public virtual DbSet<TrackingPrice> TrackingPrices { get; set; }
        public virtual DbSet<TrafficViolation> TrafficViolations { get; set; }
        public virtual DbSet<Transaction_VehicleInspection> Transaction_VehicleInspection { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<TransferItem> TransferItems { get; set; }
        public virtual DbSet<TransferType> TransferTypes { get; set; }
        public virtual DbSet<Transporter> Transporters { get; set; }
        public virtual DbSet<Transporter_Attachments> Transporter_Attachments { get; set; }
        public virtual DbSet<Transporter_ContractData> Transporter_ContractData { get; set; }
        public virtual DbSet<Transporter_Staff> Transporter_Staff { get; set; }
        public virtual DbSet<Transporter_TransporterGroup> Transporter_TransporterGroup { get; set; }
        public virtual DbSet<TransporterActivity> TransporterActivities { get; set; }
        public virtual DbSet<TransporterBrand> TransporterBrands { get; set; }
        public virtual DbSet<TransporterColor> TransporterColors { get; set; }
        public virtual DbSet<TransporterCreditLimit> TransporterCreditLimits { get; set; }
        public virtual DbSet<TransporterDynamicAttributeMap> TransporterDynamicAttributeMaps { get; set; }
        public virtual DbSet<TransporterFuelData> TransporterFuelDatas { get; set; }
        public virtual DbSet<TransporterFuelType> TransporterFuelTypes { get; set; }
        public virtual DbSet<TransporterGroup> TransporterGroups { get; set; }
        public virtual DbSet<TransporterInsuranceType> TransporterInsuranceTypes { get; set; }
        public virtual DbSet<TransporterLicenseType> TransporterLicenseTypes { get; set; }
        public virtual DbSet<TransporterManufacturer> TransporterManufacturers { get; set; }
        public virtual DbSet<TransporterMilageLog> TransporterMilageLogs { get; set; }
        public virtual DbSet<TransporterProductionYear> TransporterProductionYears { get; set; }
        public virtual DbSet<TransporterShift> TransporterShifts { get; set; }
        public virtual DbSet<TransporterSkeleton> TransporterSkeletons { get; set; }
        public virtual DbSet<TransporterSpec> TransporterSpecs { get; set; }
        public virtual DbSet<TransporterStaffRule> TransporterStaffRules { get; set; }
        public virtual DbSet<TransporterStatu> TransporterStatus { get; set; }
        public virtual DbSet<TransporterTool> TransporterTools { get; set; }
        public virtual DbSet<TransporterToolsAssignment> TransporterToolsAssignments { get; set; }
        public virtual DbSet<TransporterType> TransporterTypes { get; set; }
        public virtual DbSet<TransporterTypeAxle> TransporterTypeAxles { get; set; }
        public virtual DbSet<TransporterTypeCategory> TransporterTypeCategories { get; set; }
        public virtual DbSet<TransporterTypeMap> TransporterTypeMaps { get; set; }
        public virtual DbSet<TransporterTypeSkeleton> TransporterTypeSkeletons { get; set; }
        public virtual DbSet<TransporterTypeStaffRule> TransporterTypeStaffRules { get; set; }
        public virtual DbSet<TransporterTypeStaffRule_StaffRole> TransporterTypeStaffRule_StaffRole { get; set; }
        public virtual DbSet<TypeOfBusiness> TypeOfBusinesses { get; set; }
        public virtual DbSet<UpdateLog> UpdateLogs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserActionsAuditLog> UserActionsAuditLogs { get; set; }
        public virtual DbSet<UserActionsLogDetail> UserActionsLogDetails { get; set; }
        public virtual DbSet<UserBranchPermission> UserBranchPermissions { get; set; }
        public virtual DbSet<UserCustomField> UserCustomFields { get; set; }
        public virtual DbSet<UserTrackerProvider> UserTrackerProviders { get; set; }
        public virtual DbSet<VehicleDriverLog> VehicleDriverLogs { get; set; }
        public virtual DbSet<VehicleInspection> VehicleInspections { get; set; }
        public virtual DbSet<Vendor_Items> Vendor_Items { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Wasl_CompanyRegistration> Wasl_CompanyRegistration { get; set; }
        public virtual DbSet<Wasl_CompanyRegistration_Log> Wasl_CompanyRegistration_Log { get; set; }
        public virtual DbSet<Wasl_DriversRegistrtaion> Wasl_DriversRegistrtaion { get; set; }
        public virtual DbSet<Wasl_DriversRegistrtaion_Log> Wasl_DriversRegistrtaion_Log { get; set; }
        public virtual DbSet<Wasl_VehicleRegistration> Wasl_VehicleRegistration { get; set; }
        public virtual DbSet<Wasl_VehicleRegistration_Log> Wasl_VehicleRegistration_Log { get; set; }
        public virtual DbSet<Website> Websites { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<WorkOrderCost> WorkOrderCosts { get; set; }
        public virtual DbSet<WorkOrderLandmarkLoadDetail> WorkOrderLandmarkLoadDetails { get; set; }
        public virtual DbSet<WorkOrderLandmark> WorkOrderLandmarks { get; set; }
        public virtual DbSet<WorkOrdersLoad> WorkOrdersLoads { get; set; }
        public virtual DbSet<WorkOrderStaff> WorkOrderStaffs { get; set; }
        public virtual DbSet<InsuranceLimit> InsuranceLimits { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TransporterTemp> TransporterTemps { get; set; }
        public virtual DbSet<UserPassword> UserPasswords { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        public virtual DbSet<VersionInfo> VersionInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccCode)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccEName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccAName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Account1)
                .WithOptional(e => e.Account2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Expenses)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccType>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.AccType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.TransporterActivities)
                .WithRequired(e => e.ActivityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Adjustment>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<Adjustment>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Adjustment>()
                .Property(e => e.Quantity)
                .HasPrecision(7, 0);

            modelBuilder.Entity<Adjustment>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<AdjustmentType>()
                .Property(e => e.AdjustmentTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<AdjustmentType>()
                .HasMany(e => e.Adjustments)
                .WithRequired(e => e.AdjustmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminTool_Page>()
                .HasMany(e => e.AdminTool_RolePage)
                .WithRequired(e => e.AdminTool_Page)
                .HasForeignKey(e => e.PageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminTool_Premission>()
                .HasMany(e => e.AdminTool_RolePage)
                .WithRequired(e => e.AdminTool_Premission)
                .HasForeignKey(e => e.PremissionRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminTool_UserCategory>()
                .HasMany(e => e.AdminTool_UserRole)
                .WithOptional(e => e.AdminTool_UserCategory)
                .HasForeignKey(e => e.UserCategoryId);

            modelBuilder.Entity<AdminTool_UserRole>()
                .HasMany(e => e.AdminTool_RolePage)
                .WithRequired(e => e.AdminTool_UserRole)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminTool_UserRole>()
                .HasMany(e => e.AdminTool_UserInRole)
                .WithRequired(e => e.AdminTool_UserRole)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Membership>()
                .HasMany(e => e.ReportSubscriptionUsers)
                .WithRequired(e => e.aspnet_Membership)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.aspnet_Roles)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.StaffRoleModulePermissions)
                .WithOptional(e => e.aspnet_Roles)
                .HasForeignKey(e => e.AspNetRoleID);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_Users)
                .WithMany(e => e.aspnet_Roles)
                .Map(m => m.ToTable("aspnet_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.FuelLogs)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.created_by);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.InspectionDetails)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.InspectionDetails1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.CheckInOutTransactions)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.Distributor)
                .WithRequired(e => e.aspnet_Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.WorkOrderCosts)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.WorkOrderCosts1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.LastModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.LandmarksLoadsDetails)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.LandmarksLoadsDetails1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.LastModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.MailActions_Users)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.MaintenanceWorkorderStatusLogs)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.ChangedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationCosts)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationCosts1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.LastModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_Drugs)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_Drugs1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifyedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_DuringTransport)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_DuringTransport1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifyedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_NeonatalServices)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationLogs_NeonatalServices1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifyedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationWorkOrders)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationWorkOrders1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.LastModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationWorkOrderLandmarks)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.OperationWorkOrderLandmarks1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.LastModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.PS_OperationWorkOrder_StatusLog)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.ReportSubscriptions)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.Reseller)
                .WithRequired(e => e.aspnet_Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_GuardianAttachments)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Guardians)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Guardians1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Guardians2)
                .WithOptional(e => e.aspnet_Users2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Notifications)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.NotifiedId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Plan)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_Plan1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SCO_StudentAttachments)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.SubscriptionActivityLogs)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.TrafficViolations)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.UserCustomField)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.UserTrackerProviders)
                .WithRequired(e => e.aspnet_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.MaintenanceWorkOrderVendors)
                .WithMany(e => e.aspnet_Users)
                .Map(m => m.ToTable("MaintenanceWoVendor_Users").MapLeftKey("UserId").MapRightKey("VendorId"));

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<AttachedFile>()
                .HasMany(e => e.CheckInOutTransaction_AttachedFile)
                .WithRequired(e => e.AttachedFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Battery>()
                .HasMany(e => e.BatteryAssignments)
                .WithOptional(e => e.Battery1)
                .HasForeignKey(e => e.battery)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Branch>()
                .Property(e => e.latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Branch>()
                .Property(e => e.longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Branch1)
                .WithOptional(e => e.Branch2)
                .HasForeignKey(e => e.parentBranchId);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Maintenance_VendorBranch)
                .WithOptional(e => e.Branch1)
                .HasForeignKey(e => e.Branch);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.NotificationConfiguration_SubBranch)
                .WithRequired(e => e.Branch)
                .HasForeignKey(e => e.SubBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.NWC_Zone)
                .WithRequired(e => e.Branch)
                .HasForeignKey(e => e.CityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.PS_OperationWorkOrder)
                .WithOptional(e => e.Branch)
                .HasForeignKey(e => e.BranchId);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.PS_OperationWorkOrder1)
                .WithOptional(e => e.Branch1)
                .HasForeignKey(e => e.SubBranchId);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.PS_OperationWorkOrderCodeSerial)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.RequestForRepairs)
                .WithOptional(e => e.Branch1)
                .HasForeignKey(e => e.branch);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.SCO_Plan)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.SCO_Students)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Staffs)
                .WithOptional(e => e.Branch)
                .HasForeignKey(e => e.AllocatedBranch);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.UserBranchPermissions)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.BrandLogo)
                .IsUnicode(false);

            modelBuilder.Entity<CalculationType>()
                .Property(e => e.CalculationTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<CheckInOutTransaction>()
                .HasMany(e => e.CheckInOutTransaction_AttachedFile)
                .WithRequired(e => e.CheckInOutTransaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CheckInOutTransaction>()
                .HasMany(e => e.TrafficViolations)
                .WithRequired(e => e.CheckInOutTransaction)
                .HasForeignKey(e => e.TransactionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CheckInOutTransaction>()
                .HasMany(e => e.Transaction_VehicleInspection)
                .WithRequired(e => e.CheckInOutTransaction)
                .HasForeignKey(e => e.TransactionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<ComboItem>()
                .Property(e => e.ComboID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ComboItem>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ComboItem>()
                .Property(e => e.ItemID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Branches)
                .WithOptional(e => e.ContactPerson1)
                .HasForeignKey(e => e.contactPerson);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Distributors)
                .WithRequired(e => e.ContactPerson1)
                .HasForeignKey(e => e.contactPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Landmarks)
                .WithOptional(e => e.ContactPerson1)
                .HasForeignKey(e => e.contactPerson);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Resellers)
                .WithRequired(e => e.ContactPerson1)
                .HasForeignKey(e => e.contactPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactPerson>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.ContactPerson1)
                .HasForeignKey(e => e.contactPerson);

            modelBuilder.Entity<CountProduct>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Distributors)
                .WithRequired(e => e.Country1)
                .HasForeignKey(e => e.country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Resellers)
                .WithRequired(e => e.Country1)
                .HasForeignKey(e => e.country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.country);

            modelBuilder.Entity<CountStock>()
                .Property(e => e.CSReference)
                .IsUnicode(false);

            modelBuilder.Entity<CountStock>()
                .Property(e => e.CSType)
                .IsUnicode(false);

            modelBuilder.Entity<CountStock>()
                .Property(e => e.CSCategories)
                .IsUnicode(false);

            modelBuilder.Entity<CountStock>()
                .Property(e => e.CSGroups)
                .IsUnicode(false);

            modelBuilder.Entity<CountStock>()
                .HasMany(e => e.CountProducts)
                .WithRequired(e => e.CountStock)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.notation)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Distributors)
                .WithRequired(e => e.Currency1)
                .HasForeignKey(e => e.currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Resellers)
                .WithOptional(e => e.Currency1)
                .HasForeignKey(e => e.currency);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.SubscriberAdminSettings)
                .WithOptional(e => e.Currency)
                .HasForeignKey(e => e.FK_Currency);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.VATNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryOrder>()
                .Property(e => e.DeliveryOrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeliveryOrder>()
                .Property(e => e.DeliveryOrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryOrder>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryOrder>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryOrderDetail>()
                .Property(e => e.PackingID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeliveryOrderDetail>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeliveryOrderDetail>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryOrderDetail>()
                .Property(e => e.OrderPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DeliveryStatu>()
                .Property(e => e.DeliveryStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryStatu>()
                .Property(e => e.DeliveryStatusColor)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryStatu>()
                .HasMany(e => e.Packings)
                .WithRequired(e => e.DeliveryStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.Discount1)
                .HasForeignKey(e => e.discount);

            modelBuilder.Entity<Distributor>()
                .Property(e => e.royaltyPercentage)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Distributor>()
                .Property(e => e.currentCredit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Distributor>()
                .HasMany(e => e.DistributorBalanceHistories)
                .WithOptional(e => e.Distributor1)
                .HasForeignKey(e => e.distributor);

            modelBuilder.Entity<Distributor>()
                .HasMany(e => e.Resellers)
                .WithRequired(e => e.Distributor1)
                .HasForeignKey(e => e.distributor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DynamicAttributeType>()
                .HasMany(e => e.LandmarkTypeMaps)
                .WithRequired(e => e.DynamicAttributeType)
                .HasForeignKey(e => e.attributeTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DynamicAttributeType>()
                .HasMany(e => e.StaffRoleDynamicAttributesMaps)
                .WithOptional(e => e.DynamicAttributeType)
                .HasForeignKey(e => e.AttributeCode);

            modelBuilder.Entity<DynamicAttributeType>()
                .HasMany(e => e.TransporterTypeMaps)
                .WithRequired(e => e.DynamicAttributeType)
                .HasForeignKey(e => e.attributeTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailVerifier>()
                .Property(e => e.strError)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.ExpenseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Expense>()
                .Property(e => e.ExpenseCode)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupImage)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceType>()
                .Property(e => e.InvoiceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceType>()
                .HasMany(e => e.ScannedFiles)
                .WithRequired(e => e.InvoiceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .Property(e => e.latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Landmark>()
                .Property(e => e.longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.LandmarkDynamicAttributeMaps)
                .WithOptional(e => e.Landmark)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NotificationConfiguration_LandMarks)
                .WithRequired(e => e.Landmark1)
                .HasForeignKey(e => e.LandMark)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractPrice)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractStations)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractStationViolation)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractTariff)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractTerms)
                .WithOptional(e => e.Landmark)
                .HasForeignKey(e => e.StationID);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_DeviceMeter)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ContractAccessory)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_StationCustomerLocationClass)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_StationServiceType)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_UserLandmarkPermission)
                .WithRequired(e => e.Landmark)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.NWC_ZoneStations)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.StationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.OperationWorkOrderLandmarks)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.LandmarkFromId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.OperationWorkOrderLandmarks1)
                .WithRequired(e => e.Landmark1)
                .HasForeignKey(e => e.LandmarkToId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.Paths)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.LandmarkID);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.Paths1)
                .WithOptional(e => e.Landmark1)
                .HasForeignKey(e => e.PreviousLandmarkID);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.RequestForRepairs)
                .WithOptional(e => e.Landmark1)
                .HasForeignKey(e => e.landmark);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.SCO_PlannedTrip)
                .WithRequired(e => e.Landmark)
                .HasForeignKey(e => e.SourcePOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.SCO_PlannedTrip1)
                .WithRequired(e => e.Landmark1)
                .HasForeignKey(e => e.DestinationPOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Landmark>()
                .HasMany(e => e.Staffs)
                .WithOptional(e => e.Landmark)
                .HasForeignKey(e => e.AllocatedLandmark);

            modelBuilder.Entity<LandmarkType>()
                .HasMany(e => e.LandmarkTypeMaps)
                .WithRequired(e => e.LandmarkType1)
                .HasForeignKey(e => e.LandmarkType);

            modelBuilder.Entity<LandmarkTypeMap>()
                .HasMany(e => e.LandmarkDynamicAttributeMaps)
                .WithOptional(e => e.LandmarkTypeMap)
                .HasForeignKey(e => e.attributeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Distributors)
                .WithRequired(e => e.Language1)
                .HasForeignKey(e => e.language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Resellers)
                .WithRequired(e => e.Language1)
                .HasForeignKey(e => e.language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MailAction>()
                .HasMany(e => e.MailActions_Users)
                .WithRequired(e => e.MailAction1)
                .HasForeignKey(e => e.mailAction);

            modelBuilder.Entity<MainMenu>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<MainMenu>()
                .Property(e => e.MenuURL)
                .IsUnicode(false);

            modelBuilder.Entity<MainMenu>()
                .Property(e => e.MenuIcon)
                .IsUnicode(false);

            modelBuilder.Entity<MainMenu>()
                .HasMany(e => e.SubMenus)
                .WithRequired(e => e.MainMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenaceProblemSparPartsAssign>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Maintenance_VendorBranch>()
                .HasOptional(e => e.Maintenance_VendorBranch1)
                .WithRequired(e => e.Maintenance_VendorBranch2);

            modelBuilder.Entity<Maintenance_Vendors>()
                .HasMany(e => e.Maintenance_VendorBranch)
                .WithRequired(e => e.Maintenance_Vendors)
                .HasForeignKey(e => e.VendorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Maintenance_Vendors>()
                .HasMany(e => e.Vendor_Items)
                .WithRequired(e => e.Maintenance_Vendors)
                .HasForeignKey(e => e.VendorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenanceDelayReason>()
                .HasMany(e => e.MaintenanceProblemDelayReasons)
                .WithRequired(e => e.MaintenanceDelayReason)
                .HasForeignKey(e => e.DelayReasonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenanceDriverRole>()
                .HasMany(e => e.CheckInOutTransactions)
                .WithOptional(e => e.MaintenanceDriverRole)
                .HasForeignKey(e => e.DriverRoleId);

            modelBuilder.Entity<MaintenanceDriverRole>()
                .HasMany(e => e.RequestForRepairs)
                .WithOptional(e => e.MaintenanceDriverRole)
                .HasForeignKey(e => e.DriverRoleId);

            modelBuilder.Entity<MaintenancePM>()
                .HasOptional(e => e.MaintenancePM1)
                .WithRequired(e => e.MaintenancePM2);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMSetupTransporters)
                .WithOptional(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMTasks)
                .WithOptional(e => e.MaintenancePM)
                .HasForeignKey(e => e.PMId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMTransporters)
                .WithRequired(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMTransporterBrands)
                .WithRequired(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMTransporterManufacturers)
                .WithRequired(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.MaintenancePMTransporterTypes)
                .WithRequired(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM);

            modelBuilder.Entity<MaintenancePM>()
                .HasMany(e => e.RequestForRepairs)
                .WithOptional(e => e.MaintenancePM)
                .HasForeignKey(e => e.PM);

            modelBuilder.Entity<MaintenancePMPriority>()
                .HasMany(e => e.MaintenancePMs)
                .WithOptional(e => e.MaintenancePMPriority)
                .HasForeignKey(e => e.Priority);

            modelBuilder.Entity<MaintenancePMSetupTransporter>()
                .HasMany(e => e.MaintenancePMSetupTransporter_Log)
                .WithOptional(e => e.MaintenancePMSetupTransporter)
                .HasForeignKey(e => e.PMSetupId);

            modelBuilder.Entity<MaintenanceSparePart>()
                .HasMany(e => e.MaintenaceProblemSparPartsAssigns)
                .WithOptional(e => e.MaintenanceSparePart)
                .HasForeignKey(e => e.sparePartId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MaintenanceTireBrand>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.MaintenanceTireBrand)
                .HasForeignKey(e => e.brand);

            modelBuilder.Entity<MaintenanceTireManfacturer>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.MaintenanceTireManfacturer)
                .HasForeignKey(e => e.manfacturer);

            modelBuilder.Entity<MaintenanceTireTreadDepth>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.MaintenanceTireTreadDepth)
                .HasForeignKey(e => e.treadDepth);

            modelBuilder.Entity<MaintenanceTireType>()
                .HasMany(e => e.Tires)
                .WithRequired(e => e.MaintenanceTireType)
                .HasForeignKey(e => e.type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaintenanceTireUseType>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.MaintenanceTireUseType)
                .HasForeignKey(e => e.useType);

            modelBuilder.Entity<MaintenanceTireVendor>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.MaintenanceTireVendor)
                .HasForeignKey(e => e.vendor);

            modelBuilder.Entity<MaintenanceWorkOrder>()
                .HasOptional(e => e.MaintenanceWorkOrder1)
                .WithRequired(e => e.MaintenanceWorkOrder2);

            modelBuilder.Entity<MaintenanceWorkOrder>()
                .HasMany(e => e.MaintenanceWorkOrderAttachements)
                .WithOptional(e => e.MaintenanceWorkOrder1)
                .HasForeignKey(e => e.maintenanceWorkOrder);

            modelBuilder.Entity<MaintenanceWorkOrder>()
                .HasMany(e => e.MaintenanceWorkorderStatusLogs)
                .WithOptional(e => e.MaintenanceWorkOrder)
                .HasForeignKey(e => e.WOId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MaintenanceWorkOrder>()
                .HasMany(e => e.Problems)
                .WithOptional(e => e.MaintenanceWorkOrder)
                .HasForeignKey(e => e.workOrderId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MaintenanceWorkOrderPriority>()
                .HasMany(e => e.MaintenanceWorkOrders)
                .WithOptional(e => e.MaintenanceWorkOrderPriority)
                .HasForeignKey(e => e.priority);

            modelBuilder.Entity<MaintenanceWorkOrderType>()
                .HasMany(e => e.MaintenanceWorkOrders)
                .WithOptional(e => e.MaintenanceWorkOrderType)
                .HasForeignKey(e => e.WorkOrderType);

            modelBuilder.Entity<MaintenanceWorkOrderVendor>()
                .HasMany(e => e.MaintenancePMs)
                .WithOptional(e => e.MaintenanceWorkOrderVendor)
                .HasForeignKey(e => e.VendorId);

            modelBuilder.Entity<MaintenanceWorkOrderVendor>()
                .HasMany(e => e.MaintenanceWorkOrders)
                .WithOptional(e => e.MaintenanceWorkOrderVendor)
                .HasForeignKey(e => e.vendor)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MappedIntegrationCost>()
                .HasMany(e => e.OperationCosts)
                .WithOptional(e => e.MappedIntegrationCost)
                .HasForeignKey(e => e.MappedId);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Offer_Module)
                .WithRequired(e => e.Module1)
                .HasForeignKey(e => e.module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module1>()
                .HasMany(e => e.Pages)
                .WithRequired(e => e.Module)
                .HasForeignKey(e => e.ModuleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module1>()
                .HasMany(e => e.StaffRoleModulePermissions)
                .WithOptional(e => e.Module)
                .HasForeignKey(e => e.ModuleID);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_Customer)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_Groups)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_LandMarks)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_Staff)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_SubBranch)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationConfiguration_TransporterTypes)
                .WithRequired(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationInboxes)
                .WithOptional(e => e.NotificationConfiguration1)
                .HasForeignKey(e => e.NotificationConfiguration);

            modelBuilder.Entity<NotificationConfiguration>()
                .HasMany(e => e.NotificationsConfiguration_NotificationsRelatedTo)
                .WithRequired(e => e.NotificationConfiguration)
                .HasForeignKey(e => e.NotificationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationInbox>()
                .HasMany(e => e.NotificationInbox_EmailLog)
                .WithRequired(e => e.NotificationInbox)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationInbox>()
                .HasMany(e => e.NotificationInbox_SMSLog)
                .WithRequired(e => e.NotificationInbox)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationInbox>()
                .HasMany(e => e.NotificationInbox_InSystemLog)
                .WithRequired(e => e.NotificationInbox)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotificationsFor>()
                .HasMany(e => e.NotificationConfigurations)
                .WithOptional(e => e.NotificationsFor)
                .HasForeignKey(e => e.NotificationForId);

            modelBuilder.Entity<NotificationsFor>()
                .HasMany(e => e.NotificationsRelatedToes)
                .WithOptional(e => e.NotificationsFor)
                .HasForeignKey(e => e.NotificationForId);

            modelBuilder.Entity<NotificationsRelatedTo>()
                .HasMany(e => e.NotificationInboxes)
                .WithOptional(e => e.NotificationsRelatedTo)
                .HasForeignKey(e => e.RelatedToID);

            modelBuilder.Entity<NotificationsRelatedTo>()
                .HasMany(e => e.NotificationsConfiguration_NotificationsRelatedTo)
                .WithRequired(e => e.NotificationsRelatedTo)
                .HasForeignKey(e => e.RelatedTo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Accessory>()
                .HasMany(e => e.NWC_ContractAccessory)
                .WithRequired(e => e.NWC_Accessory)
                .HasForeignKey(e => e.AccessoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Accessory>()
                .HasMany(e => e.NWC_VehicleAccessory)
                .WithRequired(e => e.NWC_Accessory)
                .HasForeignKey(e => e.AccessoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Accessory>()
                .HasMany(e => e.NWC_WorkOrderAccessory)
                .WithRequired(e => e.NWC_Accessory)
                .HasForeignKey(e => e.AccessoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ActionLogType>()
                .HasMany(e => e.NWC_WorkOrderLog)
                .WithRequired(e => e.NWC_ActionLogType)
                .HasForeignKey(e => e.ActionLogTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_BalanceUnit>()
                .HasMany(e => e.NWC_CustomerLocationBalance)
                .WithRequired(e => e.NWC_BalanceUnit)
                .HasForeignKey(e => e.BalanceUniteID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ComplaintCategory>()
                .HasMany(e => e.NWC_WorkOrderComplaint)
                .WithRequired(e => e.NWC_ComplaintCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ComplaintPriority>()
                .HasMany(e => e.NWC_WorkOrderComplaint)
                .WithRequired(e => e.NWC_ComplaintPriority)
                .HasForeignKey(e => e.PriorityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ComplaintStatus>()
                .HasMany(e => e.NWC_WorkOrderComplaint)
                .WithRequired(e => e.NWC_ComplaintStatus)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ContactPerson>()
                .HasMany(e => e.NWC_Contractor)
                .WithOptional(e => e.NWC_ContactPerson)
                .HasForeignKey(e => e.ContactPersonId);

            modelBuilder.Entity<NWC_ContactPerson>()
                .HasMany(e => e.NWC_ContractStations)
                .WithOptional(e => e.NWC_ContactPerson)
                .HasForeignKey(e => e.ContactPersonID);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractAccessory)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractAttachment)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractPrice)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractStations)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractTariff)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contract>()
                .HasMany(e => e.NWC_ContractTerms)
                .WithRequired(e => e.NWC_Contract)
                .HasForeignKey(e => e.ContractID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ContractAccessory>()
                .Property(e => e.Charge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_Contractor>()
                .HasMany(e => e.NWC_Contract)
                .WithRequired(e => e.NWC_Contractor)
                .HasForeignKey(e => e.ContractorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Contractor>()
                .HasMany(e => e.NWC_ContractorAttachment)
                .WithRequired(e => e.NWC_Contractor)
                .HasForeignKey(e => e.ContractorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ContractPrice>()
                .Property(e => e.PriceCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_ContractStatus>()
                .HasMany(e => e.NWC_Contract)
                .WithOptional(e => e.NWC_ContractStatus)
                .HasForeignKey(e => e.ContractStatusID);

            modelBuilder.Entity<NWC_ContractTariff>()
                .Property(e => e.CubicMeterCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_ContractTariff>()
                .Property(e => e.DistanceCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_ContractTariff>()
                .Property(e => e.AfterFirstKM)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_ContractTerminationReason>()
                .HasMany(e => e.NWC_Contract)
                .WithOptional(e => e.NWC_ContractTerminationReason)
                .HasForeignKey(e => e.TerminationReasonID);

            modelBuilder.Entity<NWC_ContractTerms>()
                .Property(e => e.TotalValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_ContractTerms>()
                .HasMany(e => e.NWC_ContractStationViolation)
                .WithRequired(e => e.NWC_ContractTerms)
                .HasForeignKey(e => e.TermsID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ContractType>()
                .HasMany(e => e.NWC_Contract)
                .WithOptional(e => e.NWC_ContractType)
                .HasForeignKey(e => e.ContractTypeID);

            modelBuilder.Entity<NWC_Customer>()
                .HasMany(e => e.NWC_CustomerAccount)
                .WithRequired(e => e.NWC_Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerAccount>()
                .HasMany(e => e.NWC_SoqyaSchedules)
                .WithRequired(e => e.NWC_CustomerAccount)
                .HasForeignKey(e => e.CustomerAccountId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerAccount>()
                .HasMany(e => e.NWC_StateWorkOrder)
                .WithOptional(e => e.NWC_CustomerAccount)
                .HasForeignKey(e => e.CustomerAccountId);

            modelBuilder.Entity<NWC_CustomerLocation>()
                .HasMany(e => e.NWC_CustomerAccount)
                .WithRequired(e => e.NWC_CustomerLocation)
                .HasForeignKey(e => e.CustomerLocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocation>()
                .HasMany(e => e.NWC_CustomerLocationBalance)
                .WithRequired(e => e.NWC_CustomerLocation)
                .HasForeignKey(e => e.CustomerLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationCategory>()
                .HasMany(e => e.NWC_CustomerLocation)
                .WithRequired(e => e.NWC_CustomerLocationCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationClass>()
                .HasMany(e => e.NWC_ContractPrice)
                .WithRequired(e => e.NWC_CustomerLocationClass)
                .HasForeignKey(e => e.CustomerLocationClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationClass>()
                .HasMany(e => e.NWC_ContractTariff)
                .WithRequired(e => e.NWC_CustomerLocationClass)
                .HasForeignKey(e => e.CustomerLocationClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationClass>()
                .HasMany(e => e.NWC_CustomerLocation)
                .WithRequired(e => e.NWC_CustomerLocationClass)
                .HasForeignKey(e => e.ClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationClass>()
                .HasMany(e => e.NWC_StationCustomerLocationClass)
                .WithRequired(e => e.NWC_CustomerLocationClass)
                .HasForeignKey(e => e.CustomerLocationClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationClass>()
                .HasMany(e => e.NWC_VehicleCustomerLocationClass)
                .WithRequired(e => e.NWC_CustomerLocationClass)
                .HasForeignKey(e => e.CustomerLocationClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationPriority>()
                .HasMany(e => e.NWC_CustomerLocation)
                .WithRequired(e => e.NWC_CustomerLocationPriority)
                .HasForeignKey(e => e.PriorityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_CustomerLocationStatus>()
                .HasMany(e => e.NWC_CustomerLocation)
                .WithRequired(e => e.NWC_CustomerLocationStatus)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_DeassignReason>()
                .HasMany(e => e.NWC_EventWorkOrder)
                .WithOptional(e => e.NWC_DeassignReason)
                .HasForeignKey(e => e.DeassignReasonID);

            modelBuilder.Entity<NWC_DeassignReason>()
                .HasMany(e => e.NWC_WorkOrderLog)
                .WithOptional(e => e.NWC_DeassignReason)
                .HasForeignKey(e => e.DeassignReasonID);

            modelBuilder.Entity<NWC_DefaultTankerSize>()
                .Property(e => e.TankerPrince)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NWC_DeferredWorkOrderStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<NWC_DeferredWorkOrderStatus>()
                .HasMany(e => e.NWC_DeferredWorkOrder)
                .WithOptional(e => e.NWC_DeferredWorkOrderStatus)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<NWC_DeviceMeter>()
                .HasMany(e => e.NWC_DeviceMeterReading)
                .WithRequired(e => e.NWC_DeviceMeter)
                .HasForeignKey(e => e.DeviceMeterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_DeviceMeterReading>()
                .Property(e => e.MeterReading)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_EventWorkOrder>()
                .Property(e => e.Distance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_EventWorkOrder>()
                .HasMany(e => e.NWC_WorkOrderAccessory)
                .WithRequired(e => e.NWC_EventWorkOrder)
                .HasForeignKey(e => e.WorkOrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_EventWorkOrder>()
                .HasOptional(e => e.NWC_WorkOrderTransaction)
                .WithRequired(e => e.NWC_EventWorkOrder);

            modelBuilder.Entity<NWC_Int_ObjectLog>()
                .HasMany(e => e.NWC_Int_ObjectLogDTO)
                .WithRequired(e => e.NWC_Int_ObjectLog)
                .HasForeignKey(e => e.LogID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_PaymentType>()
                .HasMany(e => e.NWC_CustomerLocationBalance)
                .WithRequired(e => e.NWC_PaymentType)
                .HasForeignKey(e => e.PaymentTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_PersonalIDType>()
                .HasMany(e => e.NWC_Customer)
                .WithRequired(e => e.NWC_PersonalIDType)
                .HasForeignKey(e => e.IDTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_ContractPrice)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_ContractTariff)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_CustomerAccount)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_CustomerLocationBalance)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_StationServiceType)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ServiceType>()
                .HasMany(e => e.NWC_UserServicePermission)
                .WithRequired(e => e.NWC_ServiceType)
                .HasForeignKey(e => e.ServiceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .Property(e => e.TotalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .Property(e => e.NetCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .Property(e => e.Distance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .HasMany(e => e.NWC_WorkOrderComment)
                .WithRequired(e => e.NWC_StateWorkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .HasMany(e => e.NWC_WorkOrderComplaint)
                .WithRequired(e => e.NWC_StateWorkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_StateWorkOrder>()
                .HasMany(e => e.NWC_WorkOrderLog)
                .WithRequired(e => e.NWC_StateWorkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_StationOwnership>()
                .HasMany(e => e.Landmarks)
                .WithOptional(e => e.NWC_StationOwnership)
                .HasForeignKey(e => e.StationOwnershipID);

            modelBuilder.Entity<NWC_StationStatus>()
                .HasMany(e => e.Landmarks)
                .WithOptional(e => e.NWC_StationStatus)
                .HasForeignKey(e => e.StatusID);

            modelBuilder.Entity<NWC_StationWaterSource>()
                .HasMany(e => e.Landmarks)
                .WithOptional(e => e.NWC_StationWaterSource)
                .HasForeignKey(e => e.WaterSourceID);

            modelBuilder.Entity<NWC_TanckerCapacity>()
                .HasMany(e => e.NWC_ContractTariff)
                .WithOptional(e => e.NWC_TanckerCapacity)
                .HasForeignKey(e => e.TanckerCapacityId);

            modelBuilder.Entity<NWC_TermsCategory>()
                .HasMany(e => e.NWC_ContractTerms)
                .WithOptional(e => e.NWC_TermsCategory)
                .HasForeignKey(e => e.TermsCategoryID);

            modelBuilder.Entity<NWC_TermsValueUnits>()
                .HasMany(e => e.NWC_ContractTerms)
                .WithOptional(e => e.NWC_TermsValueUnits)
                .HasForeignKey(e => e.TotalValueUnitId);

            modelBuilder.Entity<NWC_VehicleLogType>()
                .Property(e => e.NameEn)
                .IsFixedLength();

            modelBuilder.Entity<NWC_WorkOrderInvoiceStatus>()
                .HasMany(e => e.NWC_StateWorkOrder)
                .WithOptional(e => e.NWC_WorkOrderInvoiceStatus)
                .HasForeignKey(e => e.InvoiceStatusID);

            modelBuilder.Entity<NWC_WorkOrderLog>()
                .Property(e => e.NetCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_WorkOrderLog>()
                .Property(e => e.TotalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_WorkOrderLog>()
                .Property(e => e.Distance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_WorkOrderPlannedRout>()
                .Property(e => e.RouteJSON)
                .IsUnicode(false);

            modelBuilder.Entity<NWC_WorkOrderPlannedRout>()
                .Property(e => e.Distance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NWC_WorkOrderTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NWC_Zone>()
                .HasMany(e => e.NWC_CustomerLocation)
                .WithRequired(e => e.NWC_Zone)
                .HasForeignKey(e => e.ZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Zone>()
                .HasMany(e => e.NWC_RestrictedZoneVehicleType)
                .WithRequired(e => e.NWC_Zone)
                .HasForeignKey(e => e.ZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_Zone>()
                .HasMany(e => e.NWC_ZoneStations)
                .WithRequired(e => e.NWC_Zone)
                .HasForeignKey(e => e.ZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NWC_ZoneStations>()
                .Property(e => e.Distance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.Offer_Module)
                .WithRequired(e => e.Offer1)
                .HasForeignKey(e => e.offer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.Offer1)
                .HasForeignKey(e => e.offer);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.SubscriberLogs)
                .WithRequired(e => e.Offer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationContract>()
                .HasMany(e => e.OperationsProjects)
                .WithOptional(e => e.OperationContract)
                .HasForeignKey(e => e.ContractId);

            modelBuilder.Entity<OperationCost>()
                .HasMany(e => e.WorkOrderCosts)
                .WithRequired(e => e.OperationCost)
                .HasForeignKey(e => e.CostId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationLoad>()
                .HasMany(e => e.OperationProjectLoads)
                .WithOptional(e => e.OperationLoad)
                .HasForeignKey(e => e.LoadId);

            modelBuilder.Entity<OperationLoad>()
                .HasMany(e => e.WorkOrdersLoads)
                .WithRequired(e => e.OperationLoad)
                .HasForeignKey(e => e.LoadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationLoadsAmountUnit>()
                .HasMany(e => e.OperationProjectLoads)
                .WithOptional(e => e.OperationLoadsAmountUnit)
                .HasForeignKey(e => e.amountUnitID);

            modelBuilder.Entity<OperationLoadsAmountUnit>()
                .HasMany(e => e.WorkOrdersLoads)
                .WithRequired(e => e.OperationLoadsAmountUnit)
                .HasForeignKey(e => e.UnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationLogs_DuringTransport>()
                .Property(e => e.O2Saturation)
                .IsFixedLength();

            modelBuilder.Entity<OperationProjectLoad>()
                .HasMany(e => e.WorkOrderLandmarkLoadDetails)
                .WithOptional(e => e.OperationProjectLoad)
                .HasForeignKey(e => e.ProjectLoadID);

            modelBuilder.Entity<OperationsProject>()
                .HasMany(e => e.OperationProjectLoads)
                .WithOptional(e => e.OperationsProject)
                .HasForeignKey(e => e.ProjectID);

            modelBuilder.Entity<OperationsProject>()
                .HasMany(e => e.ProjectMailRecipients)
                .WithOptional(e => e.OperationsProject)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<OperationsProject>()
                .HasMany(e => e.ProjectWorkOrders)
                .WithOptional(e => e.OperationsProject)
                .HasForeignKey(e => e.projectID);

            modelBuilder.Entity<OperationWorkOrder>()
                .HasMany(e => e.OperationWorkOrder1)
                .WithOptional(e => e.OperationWorkOrder2)
                .HasForeignKey(e => e.PlannedWOId);

            modelBuilder.Entity<OperationWorkOrder>()
                .HasMany(e => e.OperationWorkOrderLandmarks)
                .WithRequired(e => e.OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationWorkOrder>()
                .HasMany(e => e.OperationWorkorderStuffs)
                .WithRequired(e => e.OperationWorkOrder)
                .HasForeignKey(e => e.WorkorderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationWorkOrder>()
                .HasMany(e => e.WorkOrderCosts)
                .WithRequired(e => e.OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationWorkOrder>()
                .HasMany(e => e.WorkOrdersLoads)
                .WithRequired(e => e.OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationWorkOrderLandmark>()
                .HasMany(e => e.LandmarksLoadsDetails)
                .WithRequired(e => e.OperationWorkOrderLandmark)
                .HasForeignKey(e => e.WorkOrderLandmarkId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationWorkOrderStatu>()
                .HasMany(e => e.OperationWorkOrders)
                .WithOptional(e => e.OperationWorkOrderStatu)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<OperationWorkOrderType>()
                .HasMany(e => e.OperationWorkOrders)
                .WithOptional(e => e.OperationWorkOrderType)
                .HasForeignKey(e => e.TypeId);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderDetailID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.OrderStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.OrderStatusCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.OrderStatusColor)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.OrderStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.OrderStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Packing>()
                .Property(e => e.PackingID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Packing>()
                .Property(e => e.DeliveryOrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Packing>()
                .Property(e => e.PackingNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Packing>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<Packing>()
                .HasMany(e => e.DeliveryOrderDetails)
                .WithRequired(e => e.Packing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.Service_Pages)
                .WithRequired(e => e.Page)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Path>()
                .Property(e => e.drivingTime)
                .IsUnicode(false);

            modelBuilder.Entity<Path>()
                .Property(e => e.stoppingTime)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.PaymentName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.PaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.PaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTerm>()
                .HasMany(e => e.Distributors)
                .WithRequired(e => e.PaymentTerm1)
                .HasForeignKey(e => e.paymentTerm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTerm>()
                .HasMany(e => e.Distributors1)
                .WithRequired(e => e.PaymentTerm2)
                .HasForeignKey(e => e.paymentTerm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTerm>()
                .HasMany(e => e.Resellers)
                .WithRequired(e => e.PaymentTerm1)
                .HasForeignKey(e => e.paymentTerm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceGroup>()
                .Property(e => e.PriceGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<PriceGroup>()
                .HasMany(e => e.PriceLists)
                .WithRequired(e => e.PriceGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PriceList>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PriceType>()
                .Property(e => e.PriceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Problem>()
                .HasMany(e => e.MaintenaceProblemSparPartsAssigns)
                .WithOptional(e => e.Problem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Problem>()
                .HasMany(e => e.MaintenanceProblemDelayReasons)
                .WithRequired(e => e.Problem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Problem>()
                .HasMany(e => e.MaintenanceProblemDiscussions)
                .WithOptional(e => e.Problem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Problem>()
                .HasMany(e => e.ProblemStatusLogs)
                .WithOptional(e => e.Problem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ProblemCategory>()
                .HasMany(e => e.ProblemTypes)
                .WithOptional(e => e.ProblemCategory)
                .HasForeignKey(e => e.ProblemCatId);

            modelBuilder.Entity<ProblemSeverity>()
                .HasMany(e => e.Problems)
                .WithOptional(e => e.ProblemSeverity)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ProblemType>()
                .HasMany(e => e.MaintenancePMTasks)
                .WithOptional(e => e.ProblemType)
                .HasForeignKey(e => e.TaskType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ProblemType>()
                .HasMany(e => e.Problems)
                .WithOptional(e => e.ProblemType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductEName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductAName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.SuppSuggestion)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.BrandTag)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.MinQty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductColor)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductImage)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.SouqASN)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductImageMini)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Adjustments)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ComboItems)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ComboItems1)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.ItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CountProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DeliveryOrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PriceLists)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SaleOrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.StakeholderBarcodes)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.StockOnHands)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TrackingPrices)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransferItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Stores)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductTracking").MapLeftKey("ProductNo").MapRightKey("StoreID"));

            modelBuilder.Entity<ProductSize>()
                .Property(e => e.SizeEName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSize>()
                .Property(e => e.SizeAName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSize>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.ProductTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductUnit>()
                .Property(e => e.ProductUnitName)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectName)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.TaxIdentNo)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Expenses)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Project1)
                .WithOptional(e => e.Project2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project1>()
                .HasMany(e => e.OperationWorkOrders)
                .WithOptional(e => e.Project)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.TotalLoad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.TotalUNLoad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.TotalDistance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.TotalHours)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.TotalCosts)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .Property(e => e.Throughput)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProjectWorkOrder>()
                .HasMany(e => e.ProjectWorkOrder1)
                .WithOptional(e => e.ProjectWorkOrder2)
                .HasForeignKey(e => e.plannedWOId);

            modelBuilder.Entity<ProjectWorkOrder>()
                .HasMany(e => e.WorkOrderLandmarks)
                .WithOptional(e => e.ProjectWorkOrder)
                .HasForeignKey(e => e.WorkOrderID);

            modelBuilder.Entity<ProjectWorkOrder>()
                .HasMany(e => e.WorkOrderStaffs)
                .WithOptional(e => e.ProjectWorkOrder)
                .HasForeignKey(e => e.WorkOrderID);

            modelBuilder.Entity<PS_Cancellation_Reason>()
                .HasMany(e => e.PS_OperationWorkOrder)
                .WithOptional(e => e.PS_Cancellation_Reason)
                .HasForeignKey(e => e.CancellationReasonId);

            modelBuilder.Entity<PS_LoadType>()
                .HasMany(e => e.PS_OperationWorkOrder_LoadType)
                .WithOptional(e => e.PS_LoadType)
                .HasForeignKey(e => e.LoadTypeId);

            modelBuilder.Entity<PS_LoadType>()
                .HasMany(e => e.PS_WorkOrder_Landmark_LoadType)
                .WithOptional(e => e.PS_LoadType)
                .HasForeignKey(e => e.LoadTypeId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .Property(e => e.StartOdometer)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .Property(e => e.EndOdometer)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .Property(e => e.Cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .Property(e => e.FuelConsumption)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrder_Landmark)
                .WithOptional(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrder_LoadType)
                .WithOptional(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.OperationWorkOrderId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrder_Resources)
                .WithOptional(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrder_StatusLog)
                .WithOptional(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.WoId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrderCodeSerial)
                .WithOptional(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId);

            modelBuilder.Entity<PS_OperationWorkOrder>()
                .HasMany(e => e.PS_OperationWorkOrderLocationHistory)
                .WithRequired(e => e.PS_OperationWorkOrder)
                .HasForeignKey(e => e.WorkOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PS_OperationWorkOrder_Landmark>()
                .HasMany(e => e.PS_WorkOrder_Landmark_LoadType)
                .WithOptional(e => e.PS_OperationWorkOrder_Landmark)
                .HasForeignKey(e => e.WO_LandmarkId);

            modelBuilder.Entity<PS_OperationWorkOrder_ResourceType>()
                .HasMany(e => e.PS_OperationWorkOrder_Resources)
                .WithRequired(e => e.PS_OperationWorkOrder_ResourceType)
                .HasForeignKey(e => e.ResourceTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PS_OperationWorkOrder_Status>()
                .HasMany(e => e.PS_OperationWorkOrder)
                .WithOptional(e => e.PS_OperationWorkOrder_Status)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<PS_OperationWorkOrder_Status>()
                .HasMany(e => e.PS_OperationWorkOrder_StatusLog)
                .WithOptional(e => e.PS_OperationWorkOrder_Status)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<PS_OperationWorkOrderLocationHistory>()
                .Property(e => e.StartLatitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<PS_OperationWorkOrderLocationHistory>()
                .Property(e => e.StartLongitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<PS_OperationWorkOrderLocationHistory>()
                .Property(e => e.EndLatitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<PS_OperationWorkOrderLocationHistory>()
                .Property(e => e.EndLongitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<PS_OperationWorkOrderType>()
                .HasMany(e => e.PS_OperationWorkOrder)
                .WithOptional(e => e.PS_OperationWorkOrderType)
                .HasForeignKey(e => e.WorkOrderTypeId);

            modelBuilder.Entity<PS_Route>()
                .HasMany(e => e.PS_OperationWorkOrder)
                .WithOptional(e => e.PS_Route)
                .HasForeignKey(e => e.RouteId);

            modelBuilder.Entity<PS_Route>()
                .HasMany(e => e.PS_Route_Landmark)
                .WithOptional(e => e.PS_Route)
                .HasForeignKey(e => e.RouteId);

            modelBuilder.Entity<PS_UnitType>()
                .HasMany(e => e.PS_LoadType)
                .WithOptional(e => e.PS_UnitType)
                .HasForeignKey(e => e.UnitId);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.OrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.PurchaseOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportSubscription>()
                .HasMany(e => e.ReportSubscriptionUsers)
                .WithRequired(e => e.ReportSubscription)
                .HasForeignKey(e => e.SubscriptionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestForRepair>()
                .HasMany(e => e.Problems)
                .WithOptional(e => e.RequestForRepair)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RequestForRepair>()
                .HasMany(e => e.RequestForRepairAttachements)
                .WithRequired(e => e.RequestForRepair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestForRepair>()
                .HasMany(e => e.RequestForRepairStatusLogs)
                .WithOptional(e => e.RequestForRepair)
                .HasForeignKey(e => e.RFRId);

            modelBuilder.Entity<Reseller>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.Reseller1)
                .HasForeignKey(e => e.reseller);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Route>()
                .Property(e => e.RouteJSON)
                .IsUnicode(false);

            modelBuilder.Entity<SaleOrder>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SaleOrder>()
                .Property(e => e.OrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SaleOrder>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<SaleOrder>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<SaleOrder>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<SaleOrder>()
                .HasMany(e => e.SaleOrderDetails)
                .WithRequired(e => e.SaleOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleOrderDetail>()
                .Property(e => e.OrderDetailID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SaleOrderDetail>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SaleOrderDetail>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SaleOrderDetail>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedFile>()
                .Property(e => e.ScanID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedFile>()
                .Property(e => e.ScanTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ScannedFile>()
                .Property(e => e.InvoiceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ScannedFile>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<SCO_AbsencePlan>()
                .HasMany(e => e.SCO_AbsencePlanStudent)
                .WithRequired(e => e.SCO_AbsencePlan)
                .HasForeignKey(e => e.AbsencePlanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Class>()
                .HasMany(e => e.SCO_Students)
                .WithRequired(e => e.SCO_Class)
                .HasForeignKey(e => e.ClassId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_DailyTrip>()
                .Property(e => e.ActualRouteString)
                .IsUnicode(false);

            modelBuilder.Entity<SCO_DailyTrip>()
                .HasMany(e => e.SCO_DailyTripStudents)
                .WithRequired(e => e.SCO_DailyTrip)
                .HasForeignKey(e => e.DailyTripId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_DailyTrip>()
                .HasMany(e => e.SCO_Notifications)
                .WithRequired(e => e.SCO_DailyTrip)
                .HasForeignKey(e => e.TripId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Gender>()
                .HasMany(e => e.SCO_Students)
                .WithRequired(e => e.SCO_Gender)
                .HasForeignKey(e => e.GenderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Grade>()
                .HasMany(e => e.SCO_Class)
                .WithRequired(e => e.SCO_Grade)
                .HasForeignKey(e => e.GradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Grade>()
                .HasMany(e => e.SCO_Students)
                .WithRequired(e => e.SCO_Grade)
                .HasForeignKey(e => e.GradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Guardians>()
                .HasMany(e => e.SCO_GuardianAttachments)
                .WithRequired(e => e.SCO_Guardians)
                .HasForeignKey(e => e.GuardianId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Guardians>()
                .HasMany(e => e.SCO_StudentGuardianRelation)
                .WithRequired(e => e.SCO_Guardians)
                .HasForeignKey(e => e.GuardiansId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_IdentityType>()
                .HasMany(e => e.SCO_Guardians)
                .WithRequired(e => e.SCO_IdentityType)
                .HasForeignKey(e => e.IdentityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Plan>()
                .HasMany(e => e.SCO_PlanAttachments)
                .WithRequired(e => e.SCO_Plan)
                .HasForeignKey(e => e.PlanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Plan>()
                .HasMany(e => e.SCO_PlannedTrip)
                .WithRequired(e => e.SCO_Plan)
                .HasForeignKey(e => e.PlanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_PlannedTrip>()
                .Property(e => e.RouteString)
                .IsUnicode(false);

            modelBuilder.Entity<SCO_PlannedTrip>()
                .HasMany(e => e.SCO_DailyTrip)
                .WithRequired(e => e.SCO_PlannedTrip)
                .HasForeignKey(e => e.PlannedTripId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_PlannedTrip>()
                .HasMany(e => e.SCO_PlannedTripStudents)
                .WithRequired(e => e.SCO_PlannedTrip)
                .HasForeignKey(e => e.PlannedTripId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_PlanType>()
                .HasMany(e => e.SCO_Plan)
                .WithRequired(e => e.SCO_PlanType)
                .HasForeignKey(e => e.PlanTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_PlanType>()
                .HasMany(e => e.SCO_PlannedTrip)
                .WithOptional(e => e.SCO_PlanType)
                .HasForeignKey(e => e.PlanType);

            modelBuilder.Entity<SCO_POIType>()
                .HasMany(e => e.SCO_POI)
                .WithRequired(e => e.SCO_POIType)
                .HasForeignKey(e => e.POITypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_RelativeRelations>()
                .HasMany(e => e.SCO_StudentGuardianRelation)
                .WithRequired(e => e.SCO_RelativeRelations)
                .HasForeignKey(e => e.RelativeRelationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_AbsencePlanStudent)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_DailyTripStudents)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_Notifications)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_PlannedTripStudents)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_POI)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_StudentAttachments)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_Students>()
                .HasMany(e => e.SCO_StudentGuardianRelation)
                .WithRequired(e => e.SCO_Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_StudentTripStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SCO_StudentTripStatus>()
                .HasMany(e => e.SCO_DailyTripStudents)
                .WithRequired(e => e.SCO_StudentTripStatus)
                .HasForeignKey(e => e.StudentStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCO_TripStatus>()
                .HasMany(e => e.SCO_DailyTrip)
                .WithRequired(e => e.SCO_TripStatus)
                .HasForeignKey(e => e.TripStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.ShiftRules)
                .WithOptional(e => e.Shift1)
                .HasForeignKey(e => e.Shift)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.StaffShifts)
                .WithOptional(e => e.Shift1)
                .HasForeignKey(e => e.Shift)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.TransporterShifts)
                .WithOptional(e => e.Shift1)
                .HasForeignKey(e => e.Shift)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SLADurationType>()
                .HasMany(e => e.Problems)
                .WithOptional(e => e.SLADurationType)
                .HasForeignKey(e => e.DefaultSLADurationType);

            modelBuilder.Entity<SLADurationType>()
                .HasMany(e => e.Problems1)
                .WithOptional(e => e.SLADurationType1)
                .HasForeignKey(e => e.ActualSLADurationType);

            modelBuilder.Entity<SLADurationType>()
                .HasMany(e => e.ProblemTypes)
                .WithOptional(e => e.SLADurationType)
                .HasForeignKey(e => e.DefaultSLADurationType);

            modelBuilder.Entity<SLADurationType>()
                .HasOptional(e => e.SLADurationType1)
                .WithRequired(e => e.SLADurationType2);

            modelBuilder.Entity<SLReferenceFormat>()
                .Property(e => e.SLReferenceFormatName)
                .IsUnicode(false);

            modelBuilder.Entity<SparePartCategory>()
                .HasMany(e => e.MaintenanceSpareParts)
                .WithOptional(e => e.SparePartCategory1)
                .HasForeignKey(e => e.SparePartCategory)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .Property(e => e.salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.CheckInOutTransactions)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.MaintenanceProblemDiscussions)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.MaintenanceWorkOrders)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.engineer);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.MaintenanceWorkOrders1)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.supervisor);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NotificationConfiguration_Staff)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NotificationInboxes)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.DriverId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NotificationInbox_EmailLog)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NotificationInbox_InSystemLog)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NotificationInbox_SMSLog)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NWC_EventWorkOrder)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NWC_UserLandmarkPermission)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NWC_UserServicePermission)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NWC_WorkOrderComment)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.NWC_WorkOrderComplaint)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.RaisedBy);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.OperationsProjects)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.supervisorId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.OperationWorkOrders)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.DriverId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.OperationWorkOrders1)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.RequestedBy);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.OperationWorkorderStuffs)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.RequestForRepairs)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.DriverId);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.RequestForRepairs1)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.requestedBy);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.SCO_DailyTrip)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.DriverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.SCO_DailyTrip1)
                .WithRequired(e => e.Staff1)
                .HasForeignKey(e => e.SupervisorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.SCO_PlannedTrip)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.DriverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.SCO_PlannedTrip1)
                .WithRequired(e => e.Staff1)
                .HasForeignKey(e => e.SupervisorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.Staff1)
                .WithRequired(e => e.Staff2);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.StaffActivities)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.StaffShifts)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Transporter_Staff)
                .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.Staff)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.UserBranchPermissions)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.VehicleDriverLogs)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.CurrentDriverId);

            modelBuilder.Entity<StaffGroup>()
                .HasMany(e => e.Staff_StaffGroups)
                .WithRequired(e => e.StaffGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffRoleCategory>()
                .HasMany(e => e.StaffRoles)
                .WithRequired(e => e.StaffRoleCategory)
                .HasForeignKey(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffRoleDynamicAttributesMap>()
                .HasMany(e => e.StaffDynamicAttributeMaps)
                .WithRequired(e => e.StaffRoleDynamicAttributesMap)
                .HasForeignKey(e => e.StaffRoleDynamicAttributeID);

            modelBuilder.Entity<StaffRole>()
                .HasMany(e => e.ShiftRules)
                .WithOptional(e => e.StaffRole1)
                .HasForeignKey(e => e.StaffRole);

            modelBuilder.Entity<StaffRole>()
                .HasMany(e => e.StaffRoleDynamicAttributesMaps)
                .WithOptional(e => e.StaffRole)
                .WillCascadeOnDelete();

            modelBuilder.Entity<StaffRole>()
                .HasMany(e => e.TransporterTypeStaffRule_StaffRole)
                .WithOptional(e => e.StaffRole1)
                .HasForeignKey(e => e.staffRole)
                .WillCascadeOnDelete();

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.BarcodeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.StakeholderType)
                .IsUnicode(false);

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.BarcodeType)
                .IsUnicode(false);

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<StakeholderBarcode>()
                .Property(e => e.OfferNo)
                .IsUnicode(false);

            modelBuilder.Entity<StockOnHand>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.TrackingPrices)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Stores)
                .Map(m => m.ToTable("UserStore").MapLeftKey("StoreID").MapRightKey("UserID"));

            modelBuilder.Entity<SubMenu>()
                .Property(e => e.SubMenuName)
                .IsUnicode(false);

            modelBuilder.Entity<SubMenu>()
                .Property(e => e.SubMenuController)
                .IsUnicode(false);

            modelBuilder.Entity<SubMenu>()
                .Property(e => e.SubMenuAction)
                .IsUnicode(false);

            modelBuilder.Entity<SubMenu>()
                .Property(e => e.SubMenuIcon)
                .IsUnicode(false);

            modelBuilder.Entity<Subscriber>()
                .Property(e => e.currentCredit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Subscriber>()
                .Property(e => e.latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Subscriber>()
                .Property(e => e.longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.aspnet_Users)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.SubID);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.FuelLogs)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.sub_id);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.InspectionDetails)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.sub_id);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.MappedIntegrationCosts)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.SubID);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.OperationCosts)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.OperationWorkOrders)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.OperationWorkOrders1)
                .WithRequired(e => e.Subscriber1)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_DailyTrip)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_Grade)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_Guardians)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_Plan)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_PlannedTrip)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SCO_Students)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.SubId);

            modelBuilder.Entity<Subscriber>()
                .HasOptional(e => e.SubscriberAdminSetting)
                .WithRequired(e => e.Subscriber)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SubscriberLogs)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.subID);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.SubscriberTopUps)
                .WithRequired(e => e.Subscriber)
                .HasForeignKey(e => e.SubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.UserPasswords)
                .WithOptional(e => e.Subscriber)
                .HasForeignKey(e => e.SubId);

            modelBuilder.Entity<Subscriber>()
                .HasMany(e => e.Wasl_CompanyRegistration)
                .WithRequired(e => e.Subscriber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubscriberLog>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<SubscriberLog>()
                .Property(e => e.monthValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SubscriberTopUp>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SubscriberTopUp>()
                .Property(e => e.CreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SubscriberTopUp>()
                .Property(e => e.DebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.VATNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierInfo>()
                .HasMany(e => e.MaintenanceSpareParts)
                .WithOptional(e => e.SupplierInfo)
                .HasForeignKey(e => e.Supplier_Info_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SupplierSuggestion>()
                .Property(e => e.SupSugID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SupplierSuggestion>()
                .Property(e => e.SupSugName)
                .IsUnicode(false);

            modelBuilder.Entity<Tax>()
                .Property(e => e.TaxName)
                .IsUnicode(false);

            modelBuilder.Entity<Tax>()
                .Property(e => e.TaxValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tax>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Template_Parameters>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Template_Parameters>()
                .Property(e => e.ParameterName)
                .IsUnicode(false);

            modelBuilder.Entity<Tire>()
                .HasMany(e => e.MaintenanceTireAttachements)
                .WithOptional(e => e.Tire1)
                .HasForeignKey(e => e.Tire);

            modelBuilder.Entity<Tire>()
                .HasMany(e => e.TireAssignments)
                .WithOptional(e => e.Tire1)
                .HasForeignKey(e => e.tire)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TireSize>()
                .HasMany(e => e.Tires)
                .WithOptional(e => e.TireSize)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<TireSize>()
                .HasMany(e => e.TransporterTypeAxles)
                .WithOptional(e => e.TireSize)
                .HasForeignKey(e => e.size);

            modelBuilder.Entity<TrackingPrice>()
                .Property(e => e.PriceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TrackingPrice>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TrackingPrice>()
                .Property(e => e.Price)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TrackingPrice>()
                .Property(e => e.Seller)
                .IsUnicode(false);

            modelBuilder.Entity<TrackingPrice>()
                .Property(e => e.BarcodeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.TransferID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.ReferenceNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .HasMany(e => e.TransferItems)
                .WithRequired(e => e.Transfer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransferItem>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TransferItem>()
                .Property(e => e.TransferID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TransferItem>()
                .Property(e => e.ProductNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TransferItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TransferType>()
                .Property(e => e.TransferTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Transporter>()
                .Property(e => e.TransporterName)
                .IsUnicode(false);

            modelBuilder.Entity<Transporter>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Transporter>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Transporter>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Transporter>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TransporterBrand>()
                .HasMany(e => e.MaintenancePMTransporterBrands)
                .WithRequired(e => e.TransporterBrand1)
                .HasForeignKey(e => e.TransporterBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterGroup>()
                .HasMany(e => e.NotificationConfiguration_Groups)
                .WithRequired(e => e.TransporterGroup)
                .HasForeignKey(e => e.GroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterManufacturer>()
                .HasMany(e => e.MaintenancePMTransporterManufacturers)
                .WithRequired(e => e.TransporterManufacturer1)
                .HasForeignKey(e => e.TransporterManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterStatu>()
                .HasMany(e => e.NWC_StatusReason)
                .WithRequired(e => e.TransporterStatu)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterStatu>()
                .HasMany(e => e.NWC_WorkOrderLog)
                .WithOptional(e => e.TransporterStatu)
                .HasForeignKey(e => e.VehicleStatusID);

            modelBuilder.Entity<TransporterTool>()
                .HasMany(e => e.TransporterToolsAssignments)
                .WithOptional(e => e.TransporterTool)
                .HasForeignKey(e => e.tool)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.MaintenancePMTransporterTypes)
                .WithRequired(e => e.TransporterType1)
                .HasForeignKey(e => e.TransporterType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.NotificationConfiguration_TransporterTypes)
                .WithRequired(e => e.TransporterType1)
                .HasForeignKey(e => e.TransporterType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.NWC_RestrictedZoneVehicleType)
                .WithRequired(e => e.TransporterType)
                .HasForeignKey(e => e.VehicleTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.ShiftRules)
                .WithOptional(e => e.TransporterType1)
                .HasForeignKey(e => e.TransporterType);

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.TransporterTypeMaps)
                .WithRequired(e => e.TransporterType1)
                .HasForeignKey(e => e.transporterType);

            modelBuilder.Entity<TransporterType>()
                .HasMany(e => e.Vendor_Items)
                .WithRequired(e => e.TransporterType)
                .HasForeignKey(e => e.CarTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterTypeAxle>()
                .HasMany(e => e.TireAssignments)
                .WithOptional(e => e.TransporterTypeAxle)
                .HasForeignKey(e => e.transporterSkeletonAxle)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransporterTypeCategory>()
                .HasMany(e => e.TransporterTypes)
                .WithRequired(e => e.TransporterTypeCategory)
                .HasForeignKey(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransporterTypeMap>()
                .HasMany(e => e.TransporterDynamicAttributeMaps)
                .WithOptional(e => e.TransporterTypeMap)
                .HasForeignKey(e => e.attributeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransporterTypeSkeleton>()
                .HasMany(e => e.TransporterSkeletons)
                .WithRequired(e => e.TransporterTypeSkeleton)
                .HasForeignKey(e => e.skeletonId);

            modelBuilder.Entity<TransporterTypeSkeleton>()
                .HasMany(e => e.TransporterTypes)
                .WithOptional(e => e.TransporterTypeSkeleton)
                .HasForeignKey(e => e.skeletonID);

            modelBuilder.Entity<TransporterTypeSkeleton>()
                .HasMany(e => e.TransporterTypeAxles)
                .WithOptional(e => e.TransporterTypeSkeleton1)
                .HasForeignKey(e => e.transporterTypeSkeleton)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransporterTypeStaffRule>()
                .HasMany(e => e.TransporterStaffRules)
                .WithOptional(e => e.TransporterTypeStaffRule)
                .HasForeignKey(e => e.staffRule)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransporterTypeStaffRule>()
                .HasMany(e => e.TransporterTypes)
                .WithOptional(e => e.TransporterTypeStaffRule)
                .HasForeignKey(e => e.staffRule);

            modelBuilder.Entity<TransporterTypeStaffRule>()
                .HasMany(e => e.TransporterTypeStaffRule_StaffRole)
                .WithOptional(e => e.TransporterTypeStaffRule1)
                .HasForeignKey(e => e.transporterTypeStaffRule)
                .WillCascadeOnDelete();

            modelBuilder.Entity<UpdateLog>()
                .Property(e => e.TableName)
                .IsFixedLength();

            modelBuilder.Entity<UpdateLog>()
                .Property(e => e.ColumnName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Expenses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PriceLists)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleOrderDetails)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transfers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.SystemSetting)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Warehouses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserActionsAuditLog>()
                .HasMany(e => e.UserActionsLogDetails)
                .WithOptional(e => e.UserActionsAuditLog)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VehicleInspection>()
                .HasMany(e => e.Transaction_VehicleInspection)
                .WithRequired(e => e.VehicleInspection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor_Items>()
                .Property(e => e.ItemPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseName)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Adjustments)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.CountStocks)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.DeliveryOrders)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.SaleOrders)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.StockOnHands)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Transfers)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.FromWarehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Transfers1)
                .WithRequired(e => e.Warehouse1)
                .HasForeignKey(e => e.ToWarehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wasl_CompanyRegistration>()
                .Property(e => e.ResultCode)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_CompanyRegistration>()
                .HasMany(e => e.Wasl_CompanyRegistration_Log)
                .WithOptional(e => e.Wasl_CompanyRegistration)
                .HasForeignKey(e => e.Wasl_RegistrationId);

            modelBuilder.Entity<Wasl_CompanyRegistration_Log>()
                .Property(e => e.ResultCode)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration>()
                .Property(e => e.VehiclePlate_rightLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration>()
                .Property(e => e.VehiclePlate_middleLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration>()
                .Property(e => e.VehiclePlate_leftLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration>()
                .Property(e => e.resultCode)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration_Log>()
                .Property(e => e.VehiclePlate_rightLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration_Log>()
                .Property(e => e.VehiclePlate_middleLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration_Log>()
                .Property(e => e.VehiclePlate_leftLetter)
                .IsFixedLength();

            modelBuilder.Entity<Wasl_VehicleRegistration_Log>()
                .Property(e => e.resultCode)
                .IsFixedLength();

            modelBuilder.Entity<Website>()
                .Property(e => e.WebsiteName)
                .IsUnicode(false);

            modelBuilder.Entity<Website>()
                .Property(e => e.WebsiteLogo)
                .IsUnicode(false);

            modelBuilder.Entity<WorkOrdersLoad>()
                .HasMany(e => e.LandmarksLoadsDetails)
                .WithRequired(e => e.WorkOrdersLoad)
                .HasForeignKey(e => e.WorkOrderLoadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xfallback_drive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.phyname)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_usg>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSetting>()
                .Property(e => e.SiteName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSetting>()
                .Property(e => e.DefaultEmail)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSetting>()
                .Property(e => e.DateFormat)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSetting>()
                .Property(e => e.TimeZoneID)
                .IsUnicode(false);

            modelBuilder.Entity<TransporterTemp>()
                .Property(e => e.literPerKm)
                .HasPrecision(18, 4);
        }
    }
}
