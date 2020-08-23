namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckInOutTransaction")]
    public partial class CheckInOutTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckInOutTransaction()
        {
            CheckInOutTransaction_AttachedFile = new HashSet<CheckInOutTransaction_AttachedFile>();
            TrafficViolations = new HashSet<TrafficViolation>();
            Transaction_VehicleInspection = new HashSet<Transaction_VehicleInspection>();
        }

        public Guid ID { get; set; }

        public Guid TransporterId { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid? EmployeeId { get; set; }

        public int? FuelLevelId { get; set; }

        [StringLength(100)]
        public string FuelCard { get; set; }

        public double? Mileage { get; set; }

        public bool IsCheckIn { get; set; }

        public DateTime CheckInOutTime { get; set; }

        public bool? IsWorking { get; set; }

        public string Bravo { get; set; }

        public bool IsDeleted { get; set; }

        public bool? IsMisused { get; set; }

        [StringLength(100)]
        public string Printer { get; set; }

        [StringLength(100)]
        public string Signature { get; set; }

        public Guid? BranchId { get; set; }

        public string Comment { get; set; }

        public bool? IsAccident { get; set; }

        [StringLength(100)]
        public string AccidentNumber { get; set; }

        public DateTime? AccidentDate { get; set; }

        [StringLength(500)]
        public string AccidentAddress { get; set; }

        public int? DriverRoleId { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOutTransaction_AttachedFile> CheckInOutTransaction_AttachedFile { get; set; }

        public virtual FuelLevel FuelLevel { get; set; }

        public virtual MaintenanceDriverRole MaintenanceDriverRole { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrafficViolation> TrafficViolations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_VehicleInspection> Transaction_VehicleInspection { get; set; }
    }
}
