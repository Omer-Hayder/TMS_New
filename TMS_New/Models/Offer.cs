namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Offer")]
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            Offer_Module = new HashSet<Offer_Module>();
            Subscribers = new HashSet<Subscriber>();
            SubscriberLogs = new HashSet<SubscriberLog>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string descr { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? Role { get; set; }

        public virtual aspnet_Roles aspnet_Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer_Module> Offer_Module { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscribers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberLog> SubscriberLogs { get; set; }
    }
}
