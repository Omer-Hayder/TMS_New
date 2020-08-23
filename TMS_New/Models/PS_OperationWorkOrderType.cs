namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_OperationWorkOrderType()
        {
            PS_OperationWorkOrder = new HashSet<PS_OperationWorkOrder>();
        }

        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? SubId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder> PS_OperationWorkOrder { get; set; }
    }
}
