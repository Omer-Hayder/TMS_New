namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileGroup")]
    public partial class MobileGroup
    {
        public Guid ID { get; set; }

        [StringLength(1000)]
        public string code { get; set; }

        [Required]
        [StringLength(1000)]
        public string uniquename { get; set; }
    }
}
