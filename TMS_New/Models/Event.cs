namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int EventID { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime? EventEnd { get; set; }

        [Required]
        [StringLength(7)]
        public string EventColor { get; set; }

        public bool IsFullDay { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }
    }
}
