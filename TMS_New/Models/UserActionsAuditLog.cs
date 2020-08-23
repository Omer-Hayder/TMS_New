namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActionsAuditLog")]
    public partial class UserActionsAuditLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserActionsAuditLog()
        {
            UserActionsLogDetails = new HashSet<UserActionsLogDetail>();
        }

        [Key]
        public long LogId { get; set; }

        public Guid UserId { get; set; }

        public Guid SubId { get; set; }

        public DateTime actionDate { get; set; }

        public int actionType { get; set; }

        [StringLength(200)]
        public string tableName { get; set; }

        public string PageURL { get; set; }

        public string objectId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserActionsLogDetail> UserActionsLogDetails { get; set; }
    }
}
