namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterBrand")]
    public partial class TransporterBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterBrand()
        {
            MaintenancePMTransporterBrands = new HashSet<MaintenancePMTransporterBrand>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(100)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string DescriptionAr { get; set; }

        public Guid? TransporterManufacturerId { get; set; }

        public string BrandLogo { get; set; }

        public Guid? SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTransporterBrand> MaintenancePMTransporterBrands { get; set; }

        public virtual TransporterManufacturer TransporterManufacturer { get; set; }
    }
}
