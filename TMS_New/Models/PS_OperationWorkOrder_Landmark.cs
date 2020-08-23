namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_Landmark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_OperationWorkOrder_Landmark()
        {
            PS_WorkOrder_Landmark_LoadType = new HashSet<PS_WorkOrder_Landmark_LoadType>();
        }

        public long Id { get; set; }

        public long? WorkOrderId { get; set; }

        public Guid? LandmarkId { get; set; }

        public int? Landmark_Order { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_WorkOrder_Landmark_LoadType> PS_WorkOrder_Landmark_LoadType { get; set; }
    }
}
