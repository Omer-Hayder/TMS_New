namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Problem")]
    public partial class Problem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Problem()
        {
            MaintenaceProblemSparPartsAssigns = new HashSet<MaintenaceProblemSparPartsAssign>();
            MaintenanceProblemDelayReasons = new HashSet<MaintenanceProblemDelayReason>();
            MaintenanceProblemDiscussions = new HashSet<MaintenanceProblemDiscussion>();
            ProblemStatusLogs = new HashSet<ProblemStatusLog>();
        }

        public Guid ID { get; set; }

        public Guid? requestForRepairId { get; set; }

        public Guid? problemTypeId { get; set; }

        public Guid? problemSeverityId { get; set; }

        public string description { get; set; }

        public Guid? workOrderId { get; set; }

        public bool? isdelete { get; set; }

        public DateTime? lastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public string Notes { get; set; }

        public string suggestedSpareParts { get; set; }

        public DateTime? maintenanceStartDate { get; set; }

        public DateTime? maintenanceEndDate { get; set; }

        public int? Status { get; set; }

        public double? labourCost { get; set; }

        public double? taxesCost { get; set; }

        public double? otherCost { get; set; }

        public int? LabourCount { get; set; }

        public int? Duration { get; set; }

        public int? DurationType { get; set; }

        public string DelayReasons { get; set; }

        public double? ActualSparePartCost { get; set; }

        public int? DelayDuration { get; set; }

        public int? DelayDurationType { get; set; }

        public long? DefaultSLADuration { get; set; }

        public int? DefaultSLADurationType { get; set; }

        public long? ActualSLADuration { get; set; }

        public int? ActualSLADurationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenaceProblemSparPartsAssign> MaintenaceProblemSparPartsAssigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceProblemDelayReason> MaintenanceProblemDelayReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceProblemDiscussion> MaintenanceProblemDiscussions { get; set; }

        public virtual MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }

        public virtual ProblemSeverity ProblemSeverity { get; set; }

        public virtual ProblemType ProblemType { get; set; }

        public virtual RequestForRepair RequestForRepair { get; set; }

        public virtual SLADurationType SLADurationType { get; set; }

        public virtual SLADurationType SLADurationType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProblemStatusLog> ProblemStatusLogs { get; set; }
    }
}
