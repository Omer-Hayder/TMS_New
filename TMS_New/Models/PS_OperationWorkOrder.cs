namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_OperationWorkOrder()
        {
            PS_OperationWorkOrder_Landmark = new HashSet<PS_OperationWorkOrder_Landmark>();
            PS_OperationWorkOrder_LoadType = new HashSet<PS_OperationWorkOrder_LoadType>();
            PS_OperationWorkOrder_Resources = new HashSet<PS_OperationWorkOrder_Resources>();
            PS_OperationWorkOrder_StatusLog = new HashSet<PS_OperationWorkOrder_StatusLog>();
            PS_OperationWorkOrderCodeSerial = new HashSet<PS_OperationWorkOrderCodeSerial>();
            PS_OperationWorkOrderLocationHistory = new HashSet<PS_OperationWorkOrderLocationHistory>();
        }

        public long Id { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public DateTime PlannedEndDate { get; set; }

        public DateTime? ActualStartDate { get; set; }

        public DateTime? ActualEndDate { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? SubBranchId { get; set; }

        public Guid? TransporterId { get; set; }

        public long? RouteId { get; set; }

        public string RouteString { get; set; }

        public Guid? SubId { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        public int? CancellationReasonId { get; set; }

        public decimal? StartOdometer { get; set; }

        public decimal? EndOdometer { get; set; }

        public decimal? Cost { get; set; }

        public decimal? FuelConsumption { get; set; }

        public long? WorkOrderTypeId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Branch Branch1 { get; set; }

        public virtual PS_Cancellation_Reason PS_Cancellation_Reason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_Landmark> PS_OperationWorkOrder_Landmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_LoadType> PS_OperationWorkOrder_LoadType { get; set; }

        public virtual PS_OperationWorkOrder_Status PS_OperationWorkOrder_Status { get; set; }

        public virtual PS_OperationWorkOrderType PS_OperationWorkOrderType { get; set; }

        public virtual PS_Route PS_Route { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_Resources> PS_OperationWorkOrder_Resources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_StatusLog> PS_OperationWorkOrder_StatusLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrderCodeSerial> PS_OperationWorkOrderCodeSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrderLocationHistory> PS_OperationWorkOrderLocationHistory { get; set; }
    }
}
