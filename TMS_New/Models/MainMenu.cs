namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainMenu")]
    public partial class MainMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MainMenu()
        {
            SubMenus = new HashSet<SubMenu>();
        }

        [Key]
        public int MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        [Required]
        [StringLength(150)]
        public string MenuURL { get; set; }

        [StringLength(50)]
        public string MenuIcon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubMenu> SubMenus { get; set; }
    }
}
