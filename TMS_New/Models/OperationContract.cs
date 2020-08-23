namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationContract()
        {
            OperationsProjects = new HashSet<OperationsProject>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public double? amount { get; set; }

        public Guid customerId { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? isDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsProject> OperationsProjects { get; set; }
    }
}
