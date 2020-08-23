namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceDelayReason")]
    public partial class MaintenanceDelayReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceDelayReason()
        {
            MaintenanceProblemDelayReasons = new HashSet<MaintenanceProblemDelayReason>();
        }

        public long Id { get; set; }

        public string DelayReason { get; set; }

        public Guid? SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool Isdeleted { get; set; }

        [StringLength(50)]
        public string DelayDuration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceProblemDelayReason> MaintenanceProblemDelayReasons { get; set; }
    }
}
