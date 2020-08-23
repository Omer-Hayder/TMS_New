namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_OperationWorkOrder_Status()
        {
            PS_OperationWorkOrder = new HashSet<PS_OperationWorkOrder>();
            PS_OperationWorkOrder_StatusLog = new HashSet<PS_OperationWorkOrder_StatusLog>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? SubId { get; set; }

        public byte StatusOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder> PS_OperationWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_StatusLog> PS_OperationWorkOrder_StatusLog { get; set; }
    }
}
