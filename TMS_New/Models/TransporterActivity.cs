namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterActivity")]
    public partial class TransporterActivity
    {
        public Guid Id { get; set; }

        public Guid TransporterId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid? GenericId { get; set; }

        public byte ActivityTypeId { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ActivityType ActivityType { get; set; }
    }
}
