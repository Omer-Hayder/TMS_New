namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_DeassignReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_DeassignReason()
        {
            NWC_EventWorkOrder = new HashSet<NWC_EventWorkOrder>();
            NWC_WorkOrderLog = new HashSet<NWC_WorkOrderLog>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string ReasonAr { get; set; }

        [Required]
        [StringLength(1000)]
        public string ReasonEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_EventWorkOrder> NWC_EventWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderLog> NWC_WorkOrderLog { get; set; }
    }
}
