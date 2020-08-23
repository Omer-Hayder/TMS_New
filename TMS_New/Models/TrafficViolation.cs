namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrafficViolation")]
    public partial class TrafficViolation
    {
        public Guid ID { get; set; }

        public Guid TransactionId { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? ModificationTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(100)]
        public string Amount { get; set; }

        public DateTime? PaidOnDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual CheckInOutTransaction CheckInOutTransaction { get; set; }
    }
}
