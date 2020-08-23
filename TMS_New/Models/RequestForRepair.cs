namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestForRepair")]
    public partial class RequestForRepair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestForRepair()
        {
            Problems = new HashSet<Problem>();
            RequestForRepairAttachements = new HashSet<RequestForRepairAttachement>();
            RequestForRepairStatusLogs = new HashSet<RequestForRepairStatusLog>();
        }

        public Guid ID { get; set; }

        public int Code { get; set; }

        public Guid? DriverId { get; set; }

        public Guid? transporterId { get; set; }

        public bool? isAccident { get; set; }

        public Guid? landmark { get; set; }

        public Guid? branch { get; set; }

        public Guid? requestedBy { get; set; }

        public string policeReportNo { get; set; }

        public string policeReportFile { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid SubID { get; set; }

        public Guid? AccidentRegion { get; set; }

        public Guid? PM { get; set; }

        public bool? IsAutomatic { get; set; }

        public bool? IsHolde { get; set; }

        public int? Status { get; set; }

        public double? CurrentMileage { get; set; }

        public Guid? RelatedTransporter { get; set; }

        public string Address { get; set; }

        [StringLength(1000)]
        public string comment { get; set; }

        public DateTime? AccidentDate { get; set; }

        public Guid? DriverAccident { get; set; }

        public string StatusReason { get; set; }

        [StringLength(50)]
        public string OperationWorkOrderNumber { get; set; }

        public int? DriverRoleId { get; set; }

        public virtual Branch Branch1 { get; set; }

        public virtual Landmark Landmark1 { get; set; }

        public virtual MaintenanceDriverRole MaintenanceDriverRole { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepairAttachement> RequestForRepairAttachements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepairStatusLog> RequestForRepairStatusLogs { get; set; }
    }
}
