namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkOrdersLoad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkOrdersLoad()
        {
            LandmarksLoadsDetails = new HashSet<LandmarksLoadsDetail>();
        }

        public long ID { get; set; }

        public Guid LoadId { get; set; }

        public Guid WorkOrderId { get; set; }

        public int UnitId { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarksLoadsDetail> LandmarksLoadsDetails { get; set; }

        public virtual OperationLoad OperationLoad { get; set; }

        public virtual OperationLoadsAmountUnit OperationLoadsAmountUnit { get; set; }

        public virtual OperationWorkOrder OperationWorkOrder { get; set; }
    }
}
