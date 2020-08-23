namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_ResourceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_OperationWorkOrder_ResourceType()
        {
            PS_OperationWorkOrder_Resources = new HashSet<PS_OperationWorkOrder_Resources>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_Resources> PS_OperationWorkOrder_Resources { get; set; }
    }
}
