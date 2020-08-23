namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Battery")]
    public partial class Battery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Battery()
        {
            BatteryAssignments = new HashSet<BatteryAssignment>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string serialNo { get; set; }

        public bool? isAssigned { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatteryAssignment> BatteryAssignments { get; set; }
    }
}
