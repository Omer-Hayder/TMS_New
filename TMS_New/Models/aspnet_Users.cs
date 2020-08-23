namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspnet_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aspnet_Users()
        {
            aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
            FuelLogs = new HashSet<FuelLog>();
            InspectionDetails = new HashSet<InspectionDetail>();
            InspectionDetails1 = new HashSet<InspectionDetail>();
            CheckInOutTransactions = new HashSet<CheckInOutTransaction>();
            WorkOrderCosts = new HashSet<WorkOrderCost>();
            WorkOrderCosts1 = new HashSet<WorkOrderCost>();
            LandmarksLoadsDetails = new HashSet<LandmarksLoadsDetail>();
            LandmarksLoadsDetails1 = new HashSet<LandmarksLoadsDetail>();
            MailActions_Users = new HashSet<MailActions_Users>();
            MaintenanceWorkOrderAttachements = new HashSet<MaintenanceWorkOrderAttachement>();
            MaintenanceWorkorderStatusLogs = new HashSet<MaintenanceWorkorderStatusLog>();
            OperationCosts = new HashSet<OperationCost>();
            OperationCosts1 = new HashSet<OperationCost>();
            OperationLogs_Drugs = new HashSet<OperationLogs_Drugs>();
            OperationLogs_Drugs1 = new HashSet<OperationLogs_Drugs>();
            OperationLogs_DuringTransport = new HashSet<OperationLogs_DuringTransport>();
            OperationLogs_DuringTransport1 = new HashSet<OperationLogs_DuringTransport>();
            OperationLogs_NeonatalServices = new HashSet<OperationLogs_NeonatalServices>();
            OperationLogs_NeonatalServices1 = new HashSet<OperationLogs_NeonatalServices>();
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
            OperationWorkOrders1 = new HashSet<OperationWorkOrder>();
            OperationWorkOrderLandmarks = new HashSet<OperationWorkOrderLandmark>();
            OperationWorkOrderLandmarks1 = new HashSet<OperationWorkOrderLandmark>();
            PS_OperationWorkOrder_StatusLog = new HashSet<PS_OperationWorkOrder_StatusLog>();
            ReportSubscriptions = new HashSet<ReportSubscription>();
            SCO_GuardianAttachments = new HashSet<SCO_GuardianAttachments>();
            SCO_Guardians = new HashSet<SCO_Guardians>();
            SCO_Guardians1 = new HashSet<SCO_Guardians>();
            SCO_Guardians2 = new HashSet<SCO_Guardians>();
            SCO_Notifications = new HashSet<SCO_Notifications>();
            SCO_Plan = new HashSet<SCO_Plan>();
            SCO_Plan1 = new HashSet<SCO_Plan>();
            SCO_StudentAttachments = new HashSet<SCO_StudentAttachments>();
            Staffs = new HashSet<Staff>();
            SubscriptionActivityLogs = new HashSet<SubscriptionActivityLog>();
            TrafficViolations = new HashSet<TrafficViolation>();
            UserPasswords = new HashSet<UserPassword>();
            UserTrackerProviders = new HashSet<UserTrackerProvider>();
            aspnet_Roles = new HashSet<aspnet_Roles>();
            MaintenanceWorkOrderVendors = new HashSet<MaintenanceWorkOrderVendor>();
        }

        public Guid ApplicationId { get; set; }

        [Key]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(256)]
        public string LoweredUserName { get; set; }

        [StringLength(16)]
        public string MobileAlias { get; set; }

        public bool IsAnonymous { get; set; }

        public DateTime LastActivityDate { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? SubID { get; set; }

        public bool? IsSupperAdmin { get; set; }

        public bool? isDeleted { get; set; }

        public bool? IsSubSupperAdmin { get; set; }

        public bool CanRentInPast { get; set; }

        public bool CanReturnInPast { get; set; }

        public virtual aspnet_Applications aspnet_Applications { get; set; }

        public virtual aspnet_Membership aspnet_Membership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }

        public virtual aspnet_Profile aspnet_Profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuelLog> FuelLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionDetail> InspectionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionDetail> InspectionDetails1 { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOutTransaction> CheckInOutTransactions { get; set; }

        public virtual Distributor Distributor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderCost> WorkOrderCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderCost> WorkOrderCosts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarksLoadsDetail> LandmarksLoadsDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarksLoadsDetail> LandmarksLoadsDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailActions_Users> MailActions_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrderAttachement> MaintenanceWorkOrderAttachements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkorderStatusLog> MaintenanceWorkorderStatusLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationCost> OperationCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationCost> OperationCosts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_Drugs> OperationLogs_Drugs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_Drugs> OperationLogs_Drugs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_DuringTransport> OperationLogs_DuringTransport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_DuringTransport> OperationLogs_DuringTransport1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_NeonatalServices> OperationLogs_NeonatalServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationLogs_NeonatalServices> OperationLogs_NeonatalServices1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrderLandmark> OperationWorkOrderLandmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrderLandmark> OperationWorkOrderLandmarks1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_StatusLog> PS_OperationWorkOrder_StatusLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportSubscription> ReportSubscriptions { get; set; }

        public virtual Reseller Reseller { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_GuardianAttachments> SCO_GuardianAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Guardians> SCO_Guardians { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Guardians> SCO_Guardians1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Guardians> SCO_Guardians2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Notifications> SCO_Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Plan> SCO_Plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Plan> SCO_Plan1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_StudentAttachments> SCO_StudentAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionActivityLog> SubscriptionActivityLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrafficViolation> TrafficViolations { get; set; }

        public virtual UserCustomField UserCustomField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPassword> UserPasswords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTrackerProvider> UserTrackerProviders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrderVendor> MaintenanceWorkOrderVendors { get; set; }
    }
}
