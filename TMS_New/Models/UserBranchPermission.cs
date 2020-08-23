namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserBranchPermission")]
    public partial class UserBranchPermission
    {
        public int Id { get; set; }

        public Guid StaffId { get; set; }

        public Guid BranchId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
