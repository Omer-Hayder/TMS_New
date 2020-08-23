namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction_VehicleInspection
    {
        public Guid ID { get; set; }

        public Guid TransactionId { get; set; }

        public int VehicleInspectionId { get; set; }

        public bool? IsDamaged { get; set; }

        public virtual CheckInOutTransaction CheckInOutTransaction { get; set; }

        public virtual VehicleInspection VehicleInspection { get; set; }
    }
}
