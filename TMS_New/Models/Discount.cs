namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Discount")]
    public partial class Discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discount()
        {
            Subscribers = new HashSet<Subscriber>();
        }

        public Guid ID { get; set; }

        public double percentage { get; set; }

        public DateTime deadline { get; set; }

        public Guid SubID { get; set; }

        [StringLength(100)]
        public string descr { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
