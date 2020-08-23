namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Projects")]
    public partial class Project1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project1()
        {
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsDeleted { get; set; }

        public Guid SubId { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
