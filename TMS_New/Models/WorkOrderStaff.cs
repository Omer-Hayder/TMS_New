namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkOrderStaff")]
    public partial class WorkOrderStaff
    {
        public Guid ID { get; set; }

        public Guid? WorkOrderID { get; set; }

        public Guid? StaffID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public virtual ProjectWorkOrder ProjectWorkOrder { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
