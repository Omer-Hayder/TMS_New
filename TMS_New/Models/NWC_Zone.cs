namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Zone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_Zone()
        {
            NWC_CustomerLocation = new HashSet<NWC_CustomerLocation>();
            NWC_RestrictedZoneVehicleType = new HashSet<NWC_RestrictedZoneVehicleType>();
            NWC_ZoneStations = new HashSet<NWC_ZoneStations>();
        }

        public long ID { get; set; }

        public Guid CityID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        public bool? ZoneWithoutTanker { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerLocation> NWC_CustomerLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_RestrictedZoneVehicleType> NWC_RestrictedZoneVehicleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ZoneStations> NWC_ZoneStations { get; set; }
    }
}
