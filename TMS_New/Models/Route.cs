namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Route")]
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
            Paths = new HashSet<Path>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string routeName { get; set; }

        public Guid SubId { get; set; }

        public Guid createdBy { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public DateTime? creationTime { get; set; }

        [Column(TypeName = "text")]
        public string RouteJSON { get; set; }

        public string RouteLatLngString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Path> Paths { get; set; }
    }
}
