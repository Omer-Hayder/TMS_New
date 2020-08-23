namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partner")]
    public partial class Partner
    {
        [Key]
        [StringLength(400)]
        public string machine_id { get; set; }

        public bool flag { get; set; }
    }
}
