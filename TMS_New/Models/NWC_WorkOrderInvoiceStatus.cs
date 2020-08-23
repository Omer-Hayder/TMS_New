namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderInvoiceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_WorkOrderInvoiceStatus()
        {
            NWC_StateWorkOrder = new HashSet<NWC_StateWorkOrder>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameAr { get; set; }

        [Required]
        [StringLength(50)]
        public string NameEn { get; set; }

        public int EnumID { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StateWorkOrder> NWC_StateWorkOrder { get; set; }
    }
}
