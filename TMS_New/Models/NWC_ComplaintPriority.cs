namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ComplaintPriority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ComplaintPriority()
        {
            NWC_WorkOrderComplaint = new HashSet<NWC_WorkOrderComplaint>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string PriorityAr { get; set; }

        [StringLength(100)]
        public string PriorityEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderComplaint> NWC_WorkOrderComplaint { get; set; }
    }
}
