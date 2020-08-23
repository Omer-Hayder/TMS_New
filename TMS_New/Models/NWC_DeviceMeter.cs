namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_DeviceMeter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_DeviceMeter()
        {
            NWC_DeviceMeterReading = new HashSet<NWC_DeviceMeterReading>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ConnectorTubeNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string MeterSerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string ManholeNumber { get; set; }

        public bool? IsScadaAutoReading { get; set; }

        public int ServiceTypeID { get; set; }

        public Guid StationID { get; set; }

        public Guid SubID { get; set; }

        public virtual Landmark Landmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_DeviceMeterReading> NWC_DeviceMeterReading { get; set; }
    }
}
