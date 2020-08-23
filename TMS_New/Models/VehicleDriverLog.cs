namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleDriverLog")]
    public partial class VehicleDriverLog
    {
        public Guid ID { get; set; }

        public Guid? CurrentDriverId { get; set; }

        public DateTime? VehicleReceivingDate { get; set; }

        public DateTime? OwnershipDate { get; set; }

        public DateTime? DeallocationDate { get; set; }

        public Guid? VehicleId { get; set; }

        public bool? IsOwner { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
