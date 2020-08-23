namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ActionLogType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ActionLogType()
        {
            NWC_WorkOrderLog = new HashSet<NWC_WorkOrderLog>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string TypeAr { get; set; }

        [StringLength(50)]
        public string TypeEn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderLog> NWC_WorkOrderLog { get; set; }
    }
}
