namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_Route()
        {
            PS_OperationWorkOrder = new HashSet<PS_OperationWorkOrder>();
            PS_Route_Landmark = new HashSet<PS_Route_Landmark>();
        }

        public long Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public Guid? SubId { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public string RouteString { get; set; }

        public int? TotalTime_min { get; set; }

        public decimal? TotalDistance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder> PS_OperationWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_Route_Landmark> PS_Route_Landmark { get; set; }
    }
}
