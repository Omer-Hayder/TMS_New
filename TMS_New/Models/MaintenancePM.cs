namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePM")]
    public partial class MaintenancePM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenancePM()
        {
            MaintenancePMSetupTransporters = new HashSet<MaintenancePMSetupTransporter>();
            MaintenancePMTasks = new HashSet<MaintenancePMTask>();
            MaintenancePMTransporters = new HashSet<MaintenancePMTransporter>();
            MaintenancePMTransporterBrands = new HashSet<MaintenancePMTransporterBrand>();
            MaintenancePMTransporterManufacturers = new HashSet<MaintenancePMTransporterManufacturer>();
            MaintenancePMTransporterTypes = new HashSet<MaintenancePMTransporterType>();
            RequestForRepairs = new HashSet<RequestForRepair>();
        }

        public Guid ID { get; set; }

        public Guid? Priority { get; set; }

        public string PMName { get; set; }

        public bool IsActive { get; set; }

        public DateTime? StartingDate { get; set; }

        public string Describtion { get; set; }

        public double? DueEveryMiles { get; set; }

        public int? DueEveryday { get; set; }

        public double? NotificationsEveryMiles { get; set; }

        public int? NotificationEveryday { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? Isdeleted { get; set; }

        public bool? IsRepeated { get; set; }

        public int? VendorId { get; set; }

        public double? DueEveryWorkingHours { get; set; }

        public double? NotificationsEveryWorkingHours { get; set; }

        public virtual MaintenancePM MaintenancePM1 { get; set; }

        public virtual MaintenancePM MaintenancePM2 { get; set; }

        public virtual MaintenancePMPriority MaintenancePMPriority { get; set; }

        public virtual MaintenanceWorkOrderVendor MaintenanceWorkOrderVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMSetupTransporter> MaintenancePMSetupTransporters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTask> MaintenancePMTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporter> MaintenancePMTransporters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporterBrand> MaintenancePMTransporterBrands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporterManufacturer> MaintenancePMTransporterManufacturers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporterType> MaintenancePMTransporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs { get; set; }
    }
}
