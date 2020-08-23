namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Distributors = new HashSet<Distributor>();
            Resellers = new HashSet<Reseller>();
            Subscribers = new HashSet<Subscriber>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(3)]
        public string iSOCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string arabicName { get; set; }

        [Required]
        [StringLength(100)]
        public string englishName { get; set; }

        [Required]
        [StringLength(100)]
        public string germanName { get; set; }

        [Required]
        [StringLength(100)]
        public string spanishName { get; set; }

        [Required]
        [StringLength(100)]
        public string frenchName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Distributor> Distributors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reseller> Resellers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
