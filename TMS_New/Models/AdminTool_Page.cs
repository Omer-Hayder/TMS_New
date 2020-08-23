namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminTool_Page
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdminTool_Page()
        {
            AdminTool_RolePage = new HashSet<AdminTool_RolePage>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public string PageLink { get; set; }

        public bool? ShowInMenu { get; set; }

        public Guid ModuleId { get; set; }

        [Required]
        [StringLength(150)]
        public string UniqueName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminTool_RolePage> AdminTool_RolePage { get; set; }
    }
}
