namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterType")]
    public partial class TransporterType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterType()
        {
            MaintenancePMTransporterTypes = new HashSet<MaintenancePMTransporterType>();
            NotificationConfiguration_TransporterTypes = new HashSet<NotificationConfiguration_TransporterTypes>();
            NWC_RestrictedZoneVehicleType = new HashSet<NWC_RestrictedZoneVehicleType>();
            ShiftRules = new HashSet<ShiftRule>();
            TransporterTypeMaps = new HashSet<TransporterTypeMap>();
            Vendor_Items = new HashSet<Vendor_Items>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        [Column("transporterType")]
        public Guid? transporterType1 { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        public bool isDefault { get; set; }

        public bool? isChanged { get; set; }

        public bool? isActive { get; set; }

        public Guid createdBy { get; set; }

        public DateTime creationTime { get; set; }

        public Guid? skeletonID { get; set; }

        public Guid? staffRule { get; set; }

        public short Category { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        public double? TankCapacity { get; set; }

        public double? FuelCalibrationConst_A { get; set; }

        public double? FuelCalibrationConst_B { get; set; }

        public double? FuelCalibrationConst_C { get; set; }

        public double? FuelCalibrationConst_D { get; set; }

        [StringLength(100)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string DescriptionAr { get; set; }

        public long? ExternalSystemId { get; set; }

        public Guid? SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporterType> MaintenancePMTransporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_TransporterTypes> NotificationConfiguration_TransporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_RestrictedZoneVehicleType> NWC_RestrictedZoneVehicleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftRule> ShiftRules { get; set; }

        public virtual TransporterTypeCategory TransporterTypeCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterTypeMap> TransporterTypeMaps { get; set; }

        public virtual TransporterTypeSkeleton TransporterTypeSkeleton { get; set; }

        public virtual TransporterTypeStaffRule TransporterTypeStaffRule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor_Items> Vendor_Items { get; set; }
    }
}
