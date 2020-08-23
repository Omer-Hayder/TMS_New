namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWorkOrder")]
    public partial class MaintenanceWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceWorkOrder()
        {
            MaintenanceWorkOrderAttachements = new HashSet<MaintenanceWorkOrderAttachement>();
            MaintenanceWorkorderStatusLogs = new HashSet<MaintenanceWorkorderStatusLog>();
            Problems = new HashSet<Problem>();
        }

        public Guid ID { get; set; }

        public DateTime? DateIssued { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? ActualFinishinedDate { get; set; }

        public DateTime? ExpectedFinishinedDate { get; set; }

        public int Code { get; set; }

        public string Notes { get; set; }

        public Guid? engineer { get; set; }

        public Guid? supervisor { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? Modifiedby { get; set; }

        public int? Status { get; set; }

        public Guid? transporterId { get; set; }

        public DateTime? CreationTime { get; set; }

        public int? priority { get; set; }

        public int? WorkOrderType { get; set; }

        public int? vendor { get; set; }

        public double? CurrentMileage { get; set; }

        public string OutDoor { get; set; }

        public Guid? RelatedTransporter { get; set; }

        public int? MaintenancePlace { get; set; }

        public DateTime? WoCloseDate { get; set; }

        public bool? IgnoreAccessTime { get; set; }

        public string ChequeNumber { get; set; }

        public string BillNO { get; set; }

        public double? CompensationMoney { get; set; }

        public double? Discount { get; set; }

        public string Insuredby { get; set; }

        public DateTime? ReceivingDate { get; set; }

        public string VendorNotes { get; set; }

        public string ManagerNotes { get; set; }

        public string CancelReason { get; set; }

        public string SubEngineer { get; set; }

        [StringLength(50)]
        public string InvoiceNO { get; set; }

        public string InvoicePath { get; set; }

        public double? ExtraFees { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual MaintenanceWorkOrder MaintenanceWorkOrder1 { get; set; }

        public virtual MaintenanceWorkOrder MaintenanceWorkOrder2 { get; set; }

        public virtual MaintenanceWorkOrderPriority MaintenanceWorkOrderPriority { get; set; }

        public virtual MaintenanceWorkOrderType MaintenanceWorkOrderType { get; set; }

        public virtual MaintenanceWorkOrderVendor MaintenanceWorkOrderVendor { get; set; }

        public virtual Staff Staff1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrderAttachement> MaintenanceWorkOrderAttachements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkorderStatusLog> MaintenanceWorkorderStatusLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems { get; set; }
    }
}
