namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterGroup")]
    public partial class TransporterGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterGroup()
        {
            NotificationConfiguration_Groups = new HashSet<NotificationConfiguration_Groups>();
            Transporter_TransporterGroup = new HashSet<Transporter_TransporterGroup>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_Groups> NotificationConfiguration_Groups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporter_TransporterGroup> Transporter_TransporterGroup { get; set; }
    }
}
