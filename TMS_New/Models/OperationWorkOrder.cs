namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationWorkOrder")]
    public partial class OperationWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationWorkOrder()
        {
            OperationWorkOrder1 = new HashSet<OperationWorkOrder>();
            OperationWorkOrderLandmarks = new HashSet<OperationWorkOrderLandmark>();
            OperationWorkorderStuffs = new HashSet<OperationWorkorderStuff>();
            WorkOrderCosts = new HashSet<WorkOrderCost>();
            WorkOrdersLoads = new HashSet<WorkOrdersLoad>();
        }

        public Guid ID { get; set; }

        public string Reference { get; set; }

        public Guid SubId { get; set; }

        public bool IsPlanned { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? ProjectId { get; set; }

        public Guid TransporterId { get; set; }

        public Guid? TrailerId { get; set; }

        public Guid? PlannedWOId { get; set; }

        public string Notes { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public double? StartKM { get; set; }

        public double? EndKM { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? RouteId { get; set; }

        public DateTime? CloseDate { get; set; }

        public Guid? DriverId { get; set; }

        public double? FuelConsumed { get; set; }

        public double? FuelCost { get; set; }

        public Guid? RequestedBy { get; set; }

        public int? StatusId { get; set; }

        public int? TypeId { get; set; }

        public long? serialnum { get; set; }

        [StringLength(50)]
        public string prefix { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual Route Route { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrder1 { get; set; }

        public virtual OperationWorkOrder OperationWorkOrder2 { get; set; }

        public virtual OperationWorkOrderStatu OperationWorkOrderStatu { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        public virtual OperationWorkOrderType OperationWorkOrderType { get; set; }

        public virtual Project1 Project { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Subscriber Subscriber1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrderLandmark> OperationWorkOrderLandmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkorderStuff> OperationWorkorderStuffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderCost> WorkOrderCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrdersLoad> WorkOrdersLoads { get; set; }
    }
}
