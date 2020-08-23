namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporter_Staff
    {
        public Guid Id { get; set; }

        public Guid? Transporter { get; set; }

        public Guid? Staff { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? IsOwner { get; set; }

        public DateTime? OwnershipDate { get; set; }

        public DateTime? VehicleReceivingDate { get; set; }

        public virtual Staff Staff1 { get; set; }
    }
}
