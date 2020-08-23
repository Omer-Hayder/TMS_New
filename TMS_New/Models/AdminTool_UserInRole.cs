namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminTool_UserInRole
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RoleId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? LastUpdatedBy { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public virtual AdminTool_UserRole AdminTool_UserRole { get; set; }
    }
}
