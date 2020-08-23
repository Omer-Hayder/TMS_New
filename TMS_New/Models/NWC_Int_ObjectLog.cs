namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Int_ObjectLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_Int_ObjectLog()
        {
            NWC_Int_ObjectLogDTO = new HashSet<NWC_Int_ObjectLogDTO>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderNumber { get; set; }

        public int? OperationTypeID { get; set; }

        public int? OperationStepID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Int_ObjectLogDTO> NWC_Int_ObjectLogDTO { get; set; }
    }
}
