namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountStock")]
    public partial class CountStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CountStock()
        {
            CountProducts = new HashSet<CountProduct>();
        }

        public int CountStockID { get; set; }

        public DateTime CSDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CSReference { get; set; }

        [Required]
        [StringLength(1)]
        public string CSType { get; set; }

        [StringLength(150)]
        public string CSCategories { get; set; }

        [StringLength(150)]
        public string CSGroups { get; set; }

        public DateTime? ActualDate { get; set; }

        public Guid? UserID { get; set; }

        public int WarehouseID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountProduct> CountProducts { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
