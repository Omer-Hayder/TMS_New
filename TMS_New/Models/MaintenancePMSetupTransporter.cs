namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePMSetupTransporter")]
    public partial class MaintenancePMSetupTransporter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenancePMSetupTransporter()
        {
            MaintenancePMSetupTransporter_Log = new HashSet<MaintenancePMSetupTransporter_Log>();
        }

        public Guid Id { get; set; }

        public Guid? Transporter { get; set; }

        public Guid? PM { get; set; }

        public double? NextPMMilage { get; set; }

        public DateTime? NextDate { get; set; }

        public DateTime? DateIn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsNotifiedDate { get; set; }

        public bool? Done { get; set; }

        public bool? IsNotifiedMileage { get; set; }

        public bool? IsNotifiedHours { get; set; }

        public double? NextPMHours { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMSetupTransporter_Log> MaintenancePMSetupTransporter_Log { get; set; }
    }
}
