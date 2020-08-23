namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_LoadType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_LoadType()
        {
            PS_OperationWorkOrder_LoadType = new HashSet<PS_OperationWorkOrder_LoadType>();
            PS_WorkOrder_Landmark_LoadType = new HashSet<PS_WorkOrder_Landmark_LoadType>();
        }

        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? UnitId { get; set; }

        public Guid? SubId { get; set; }

        public bool? IsDefault { get; set; }

        public virtual PS_UnitType PS_UnitType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_LoadType> PS_OperationWorkOrder_LoadType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_WorkOrder_Landmark_LoadType> PS_WorkOrder_Landmark_LoadType { get; set; }
    }
}
