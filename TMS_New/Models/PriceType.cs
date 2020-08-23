namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceType")]
    public partial class PriceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceType()
        {
            PriceGroups = new HashSet<PriceGroup>();
        }

        public int PriceTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string PriceTypeName { get; set; }

        public int? CalculationTypeID { get; set; }

        public virtual CalculationType CalculationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceGroup> PriceGroups { get; set; }
    }
}
