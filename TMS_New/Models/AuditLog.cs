namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditLog")]
    public partial class AuditLog
    {
        public int ID { get; set; }

        [StringLength(1000)]
        public string Command { get; set; }

        [StringLength(24)]
        public string PostTime { get; set; }

        [StringLength(100)]
        public string HostName { get; set; }

        [StringLength(100)]
        public string LoginName { get; set; }
    }
}
