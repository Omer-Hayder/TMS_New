namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Path")]
    public partial class Path
    {
        public Guid Id { get; set; }

        public Guid RouteId { get; set; }

        public int landmarkOrder { get; set; }

        public Guid LandmarkID { get; set; }

        public int? distance { get; set; }

        [StringLength(50)]
        public string drivingTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public DateTime? creationTime { get; set; }

        public Guid? createdBy { get; set; }

        [StringLength(50)]
        public string stoppingTime { get; set; }

        public Guid? SubID { get; set; }

        public Guid? PreviousLandmarkID { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual Landmark Landmark1 { get; set; }

        public virtual Route Route { get; set; }
    }
}
