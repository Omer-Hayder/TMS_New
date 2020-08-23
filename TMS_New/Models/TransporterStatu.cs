namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransporterStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterStatu()
        {
            NWC_StatusReason = new HashSet<NWC_StatusReason>();
            NWC_WorkOrderLog = new HashSet<NWC_WorkOrderLog>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public bool? IsSold { get; set; }

        public bool? IsTotalLoss { get; set; }

        public string NameAr { get; set; }

        [StringLength(10)]
        public string ColorCode { get; set; }

        public long? ExternalSystemId { get; set; }

        public bool? IsManualChange { get; set; }

        [StringLength(500)]
        public string NextStatusIDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StatusReason> NWC_StatusReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderLog> NWC_WorkOrderLog { get; set; }
    }
}
