namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffDynamicAttributeMap")]
    public partial class StaffDynamicAttributeMap
    {
        public Guid ID { get; set; }

        public Guid StaffRoleDynamicAttributeID { get; set; }

        public Guid StaffID { get; set; }

        public string AttributeValue { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual StaffRoleDynamicAttributesMap StaffRoleDynamicAttributesMap { get; set; }
    }
}
