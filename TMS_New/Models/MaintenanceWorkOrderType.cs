namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWorkOrderType")]
    public partial class MaintenanceWorkOrderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceWorkOrderType()
        {
            MaintenanceWorkOrders = new HashSet<MaintenanceWorkOrder>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public int? Type { get; set; }

        public bool? Isdeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrder> MaintenanceWorkOrders { get; set; }
    }
}
