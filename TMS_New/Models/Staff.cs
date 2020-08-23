namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            CheckInOutTransactions = new HashSet<CheckInOutTransaction>();
            CustomNotificationLogs = new HashSet<CustomNotificationLog>();
            DriversFines = new HashSet<DriversFine>();
            MaintenanceProblemDiscussions = new HashSet<MaintenanceProblemDiscussion>();
            MaintenanceWorkOrders = new HashSet<MaintenanceWorkOrder>();
            MaintenanceWorkOrders1 = new HashSet<MaintenanceWorkOrder>();
            NotificationConfiguration_Staff = new HashSet<NotificationConfiguration_Staff>();
            NotificationInboxes = new HashSet<NotificationInbox>();
            NotificationInbox_EmailLog = new HashSet<NotificationInbox_EmailLog>();
            NotificationInbox_InSystemLog = new HashSet<NotificationInbox_InSystemLog>();
            NotificationInbox_SMSLog = new HashSet<NotificationInbox_SMSLog>();
            NWC_ContractStationViolation = new HashSet<NWC_ContractStationViolation>();
            NWC_EventWorkOrder = new HashSet<NWC_EventWorkOrder>();
            NWC_UserLandmarkPermission = new HashSet<NWC_UserLandmarkPermission>();
            NWC_UserServicePermission = new HashSet<NWC_UserServicePermission>();
            NWC_WorkOrderComment = new HashSet<NWC_WorkOrderComment>();
            NWC_WorkOrderComplaint = new HashSet<NWC_WorkOrderComplaint>();
            OperationsProjects = new HashSet<OperationsProject>();
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
            OperationWorkOrders1 = new HashSet<OperationWorkOrder>();
            OperationWorkorderStuffs = new HashSet<OperationWorkorderStuff>();
            ProjectMailRecipients = new HashSet<ProjectMailRecipient>();
            PS_OperationWorkOrder_Resources = new HashSet<PS_OperationWorkOrder_Resources>();
            RequestForRepairs = new HashSet<RequestForRepair>();
            RequestForRepairs1 = new HashSet<RequestForRepair>();
            SCO_DailyTrip = new HashSet<SCO_DailyTrip>();
            SCO_DailyTrip1 = new HashSet<SCO_DailyTrip>();
            SCO_PlannedTrip = new HashSet<SCO_PlannedTrip>();
            SCO_PlannedTrip1 = new HashSet<SCO_PlannedTrip>();
            Staff_Attachments = new HashSet<Staff_Attachments>();
            Staff_StaffGroups = new HashSet<Staff_StaffGroups>();
            StaffActivities = new HashSet<StaffActivity>();
            StaffDynamicAttributeMaps = new HashSet<StaffDynamicAttributeMap>();
            StaffShifts = new HashSet<StaffShift>();
            Transporter_Staff = new HashSet<Transporter_Staff>();
            UserBranchPermissions = new HashSet<UserBranchPermission>();
            VehicleDriverLogs = new HashSet<VehicleDriverLog>();
            WorkOrderStaffs = new HashSet<WorkOrderStaff>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        public Guid subID { get; set; }

        public Guid? staffRoleID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public string image { get; set; }

        public bool isAllocated { get; set; }

        [StringLength(50)]
        public string personalID { get; set; }

        public Guid? AllocatedBranch { get; set; }

        public Guid? AllocatedLandmark { get; set; }

        public Guid? status { get; set; }

        public Guid? employmentType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? employmentDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? salary { get; set; }

        [StringLength(50)]
        public string mobileNumber { get; set; }

        public bool? MonitorFlag { get; set; }

        public DateTime? HireDate { get; set; }

        public double? LaborRate { get; set; }

        public string LisenceNumber { get; set; }

        public DateTime? LisenceIssueDate { get; set; }

        public DateTime? LisenceExpiryDate { get; set; }

        public string InsuranceNumber { get; set; }

        public DateTime? InsuranceIssueDate { get; set; }

        public Guid? InsuranceCompanyID { get; set; }

        public DateTime? Birthday { get; set; }

        public int? MaritalStatus { get; set; }

        public int? Gender { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string EmergencyContactName1 { get; set; }

        public string EmergencyContactName2 { get; set; }

        public string EmergencyContactPhone1 { get; set; }

        public string EmergencyContactPhone2 { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Guid? UserID { get; set; }

        public string Email { get; set; }

        public string StaffRoleName { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        [StringLength(100)]
        public string EmploymentDateHijri { get; set; }

        [StringLength(100)]
        public string HireDateHijri { get; set; }

        [StringLength(100)]
        public string LicenseIssueDateHijri { get; set; }

        [StringLength(100)]
        public string LicenseExpiryDateHijri { get; set; }

        [StringLength(100)]
        public string InsuranceIssueDateHijri { get; set; }

        [StringLength(100)]
        public string BirthdayHijri { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOutTransaction> CheckInOutTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomNotificationLog> CustomNotificationLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DriversFine> DriversFines { get; set; }

        public virtual InsuranceCompany InsuranceCompany { get; set; }

        public virtual Landmark Landmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceProblemDiscussion> MaintenanceProblemDiscussions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrder> MaintenanceWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrder> MaintenanceWorkOrders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_Staff> NotificationConfiguration_Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox> NotificationInboxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_EmailLog> NotificationInbox_EmailLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_InSystemLog> NotificationInbox_InSystemLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_SMSLog> NotificationInbox_SMSLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStationViolation> NWC_ContractStationViolation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_EventWorkOrder> NWC_EventWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_UserLandmarkPermission> NWC_UserLandmarkPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_UserServicePermission> NWC_UserServicePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderComment> NWC_WorkOrderComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderComplaint> NWC_WorkOrderComplaint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsProject> OperationsProjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkorderStuff> OperationWorkorderStuffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMailRecipient> ProjectMailRecipients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_Resources> PS_OperationWorkOrder_Resources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTrip> SCO_DailyTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTrip> SCO_DailyTrip1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Attachments> Staff_Attachments { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Staff Staff2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_StaffGroups> Staff_StaffGroups { get; set; }

        public virtual StaffRole StaffRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffActivity> StaffActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDynamicAttributeMap> StaffDynamicAttributeMaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffShift> StaffShifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporter_Staff> Transporter_Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBranchPermission> UserBranchPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleDriverLog> VehicleDriverLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderStaff> WorkOrderStaffs { get; set; }
    }
}
