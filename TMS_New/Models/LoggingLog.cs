namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoggingLog")]
    public partial class LoggingLog
    {
        public Guid ID { get; set; }

        public Guid UserId { get; set; }

        public bool IsLogged { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
