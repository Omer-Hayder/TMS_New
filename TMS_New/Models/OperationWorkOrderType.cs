namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationWorkOrderType")]
    public partial class OperationWorkOrderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationWorkOrderType()
        {
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
        }

        public int ID { get; set; }

        [Required]
        public string TypeName { get; set; }

        public Guid SubId { get; set; }

        public bool IsMoneyExchange { get; set; }

        public bool IsRoute { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }
    }
}
