namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MailAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MailAction()
        {
            MailActions_Users = new HashSet<MailActions_Users>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string MailTemplate { get; set; }

        public Guid SubID { get; set; }

        public Guid? createdBy { get; set; }

        public DateTime? creationTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailActions_Users> MailActions_Users { get; set; }
    }
}
