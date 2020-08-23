namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationWorkorderStuff")]
    public partial class OperationWorkorderStuff
    {
        public long ID { get; set; }

        public Guid WorkorderId { get; set; }

        public Guid StaffId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public bool? IsCompany { get; set; }

        public virtual OperationWorkOrder OperationWorkOrder { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
