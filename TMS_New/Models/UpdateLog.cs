namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UpdateLog")]
    public partial class UpdateLog
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TableName { get; set; }

        [StringLength(100)]
        public string ColumnName { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public string OldValue { get; set; }

        [Required]
        public string CurrentValue { get; set; }
    }
}
