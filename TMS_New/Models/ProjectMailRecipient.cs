namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectMailRecipient")]
    public partial class ProjectMailRecipient
    {
        public Guid Id { get; set; }

        public Guid? ProjectId { get; set; }

        public Guid? staffId { get; set; }

        [StringLength(256)]
        public string email { get; set; }

        public bool? isExternal { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public virtual OperationsProject OperationsProject { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
