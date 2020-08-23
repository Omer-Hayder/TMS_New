namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TireAssignment")]
    public partial class TireAssignment
    {
        public Guid ID { get; set; }

        public Guid? tire { get; set; }

        public Guid? transporterSkeletonAxle { get; set; }

        public int? tireSkeletonPosition { get; set; }

        public Guid? transporter { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isRight { get; set; }

        public int? WoCode { get; set; }

        public string Comments { get; set; }

        public double? Pressure { get; set; }

        public int Mileage { get; set; }

        public int? Thread { get; set; }

        public DateTime? DateIn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public int? tireOrder { get; set; }

        public virtual Tire Tire1 { get; set; }

        public virtual TransporterTypeAxle TransporterTypeAxle { get; set; }
    }
}
