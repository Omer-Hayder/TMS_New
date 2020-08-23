namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationLoadsAmountUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationLoadsAmountUnit()
        {
            OperationProjectLoads = new HashSet<OperationProjectLoad>();
            WorkOrdersLoads = new HashSet<WorkOrdersLoad>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string AmountUnit { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public Guid? SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationProjectLoad> OperationProjectLoads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrdersLoad> WorkOrdersLoads { get; set; }
    }
}
