namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_StationStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_StationStatus()
        {
            Landmarks = new HashSet<Landmark>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string StatusAr { get; set; }

        [StringLength(50)]
        public string StatusEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landmark> Landmarks { get; set; }
    }
}
