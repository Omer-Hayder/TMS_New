namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileToken")]
    public partial class MobileToken
    {
        public Guid ID { get; set; }

        public Guid staffid { get; set; }

        [Required]
        [StringLength(1000)]
        public string token { get; set; }

        [Required]
        [StringLength(100)]
        public string type { get; set; }

        [Required]
        [StringLength(1000)]
        public string devicecode { get; set; }
    }
}
