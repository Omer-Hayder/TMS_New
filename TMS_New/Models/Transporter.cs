namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transporter")]
    public partial class Transporter
    {
        public int TransporterID { get; set; }

        [Required]
        [StringLength(50)]
        public string TransporterName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(10)]
        public string Telephone { get; set; }

        [StringLength(250)]
        public string Address { get; set; }
    }
}
