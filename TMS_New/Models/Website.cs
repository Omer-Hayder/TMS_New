namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Website")]
    public partial class Website
    {
        public int WebsiteID { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteName { get; set; }

        [StringLength(150)]
        public string WebsiteLogo { get; set; }
    }
}
