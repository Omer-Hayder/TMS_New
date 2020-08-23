namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductType")]
    public partial class ProductType
    {
        public int ProductTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductTypeName { get; set; }
    }
}
