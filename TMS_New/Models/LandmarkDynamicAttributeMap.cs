namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LandmarkDynamicAttributeMap")]
    public partial class LandmarkDynamicAttributeMap
    {
        public Guid Id { get; set; }

        public Guid? attributeId { get; set; }

        public Guid? LandmarkId { get; set; }

        public string attributeValue { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual LandmarkTypeMap LandmarkTypeMap { get; set; }
    }
}
