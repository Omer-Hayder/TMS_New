namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterProductionYear")]
    public partial class TransporterProductionYear
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? SubID { get; set; }
    }
}
