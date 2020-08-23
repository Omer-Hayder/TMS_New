namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserActionsLogDetail
    {
        public long Id { get; set; }

        public long? LogId { get; set; }

        [StringLength(200)]
        public string columnName { get; set; }

        public string oldValue { get; set; }

        public string newValue { get; set; }

        public virtual UserActionsAuditLog UserActionsAuditLog { get; set; }
    }
}
