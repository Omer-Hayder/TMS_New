namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IButtonTable")]
    public partial class IButtonTable
    {
        public long ID { get; set; }

        public Guid TransporterId { get; set; }

        [Required]
        [StringLength(255)]
        public string IButtonValue { get; set; }

        public bool IsAssignment { get; set; }

        public bool IsNotified { get; set; }
    }
}
