namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSize")]
    public partial class ProductSize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSize()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int SizeID { get; set; }

        [Required]
        [StringLength(50)]
        public string SizeEName { get; set; }

        [Required]
        [StringLength(50)]
        public string SizeAName { get; set; }

        [Required]
        [StringLength(15)]
        public string SizeCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
