namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationProjectLoad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationProjectLoad()
        {
            WorkOrderLandmarkLoadDetails = new HashSet<WorkOrderLandmarkLoadDetail>();
        }

        public Guid Id { get; set; }

        public Guid? ProjectID { get; set; }

        public Guid? LoadId { get; set; }

        public int? LoadIndex { get; set; }

        public double? amount { get; set; }

        public int? amountUnitID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public virtual OperationLoad OperationLoad { get; set; }

        public virtual OperationLoadsAmountUnit OperationLoadsAmountUnit { get; set; }

        public virtual OperationsProject OperationsProject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderLandmarkLoadDetail> WorkOrderLandmarkLoadDetails { get; set; }
    }
}
