namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectWorkOrder")]
    public partial class ProjectWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectWorkOrder()
        {
            ProjectWorkOrder1 = new HashSet<ProjectWorkOrder>();
            WorkOrderLandmarks = new HashSet<WorkOrderLandmark>();
            WorkOrderStaffs = new HashSet<WorkOrderStaff>();
        }

        public Guid ID { get; set; }

        public Guid? projectID { get; set; }

        public int? WorkOrderID { get; set; }

        public Guid? plannedWOId { get; set; }

        [StringLength(50)]
        public string WorkOrderReference { get; set; }

        public string Notes { get; set; }

        public Guid? TransporterID { get; set; }

        public Guid? TrailerID { get; set; }

        public bool isOutAndBack { get; set; }

        public string LandmarksPathJson { get; set; }

        public double? Fuelrate { get; set; }

        public double? FuelCost { get; set; }

        public double? TransportCost { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public double? PortScalesCost { get; set; }

        public double? RoadScalesCost { get; set; }

        public double? TollStationCost { get; set; }

        public double? DriverAllowanceCost { get; set; }

        public double? GratuityCost { get; set; }

        public double? PortPermitsCost { get; set; }

        public Guid? MaintenanceWOId { get; set; }

        public double? RFMaintenanceCost { get; set; }

        public double? MaintenanceCost { get; set; }

        public double? FinesCost { get; set; }

        public double? OtherCost { get; set; }

        public bool isDeleted { get; set; }

        public bool isPlanned { get; set; }

        public double? StartKM { get; set; }

        public double? EndKM { get; set; }

        public decimal? TotalLoad { get; set; }

        public decimal? TotalUNLoad { get; set; }

        public decimal? TotalDistance { get; set; }

        public decimal? TotalHours { get; set; }

        public decimal? TotalCosts { get; set; }

        public decimal? Throughput { get; set; }

        public virtual OperationsProject OperationsProject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectWorkOrder> ProjectWorkOrder1 { get; set; }

        public virtual ProjectWorkOrder ProjectWorkOrder2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderLandmark> WorkOrderLandmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderStaff> WorkOrderStaffs { get; set; }
    }
}
