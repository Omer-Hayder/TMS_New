namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminTool_RolePage
    {
        [Key]
        [Column(Order = 0)]
        public Guid RoleId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PageId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PremissionRoleId { get; set; }

        public bool? IsDefaultPage { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? LastUpdatedBy { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public virtual AdminTool_Page AdminTool_Page { get; set; }

        public virtual AdminTool_Premission AdminTool_Premission { get; set; }

        public virtual AdminTool_UserRole AdminTool_UserRole { get; set; }
    }
}
