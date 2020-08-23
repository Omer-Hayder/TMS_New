namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminTool_UserRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdminTool_UserRole()
        {
            AdminTool_RolePage = new HashSet<AdminTool_RolePage>();
            AdminTool_UserInRole = new HashSet<AdminTool_UserInRole>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public int? UserCategoryId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? LastUpdatedBy { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminTool_RolePage> AdminTool_RolePage { get; set; }

        public virtual AdminTool_UserCategory AdminTool_UserCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminTool_UserInRole> AdminTool_UserInRole { get; set; }
    }
}
