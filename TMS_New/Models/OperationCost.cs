namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationCost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationCost()
        {
            WorkOrderCosts = new HashSet<WorkOrderCost>();
        }

        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        public double DefaultValue { get; set; }

        public int? MappedId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid SubId { get; set; }

        public bool IsPredifined { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isBonus { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual MappedIntegrationCost MappedIntegrationCost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderCost> WorkOrderCosts { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
