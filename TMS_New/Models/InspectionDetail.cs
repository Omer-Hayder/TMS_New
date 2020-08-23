namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InspectionDetail
    {
        public long ID { get; set; }

        [StringLength(500)]
        public string InspectorName { get; set; }

        [StringLength(500)]
        public string InspectorAutority { get; set; }

        public DateTime? InspectionDate { get; set; }

        public string InspectionResult { get; set; }

        public Guid? LandmarkId { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? sub_id { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
