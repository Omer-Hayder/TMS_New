namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_PersonalIDType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_PersonalIDType()
        {
            NWC_Customer = new HashSet<NWC_Customer>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string NameAr { get; set; }

        [StringLength(50)]
        public string NameEn { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Customer> NWC_Customer { get; set; }
    }
}
