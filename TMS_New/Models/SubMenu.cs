namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubMenu")]
    public partial class SubMenu
    {
        public int SubMenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubMenuName { get; set; }

        [Required]
        [StringLength(50)]
        public string SubMenuController { get; set; }

        [Required]
        [StringLength(50)]
        public string SubMenuAction { get; set; }

        [StringLength(50)]
        public string SubMenuIcon { get; set; }

        public int MenuId { get; set; }

        public virtual MainMenu MainMenu { get; set; }
    }
}
