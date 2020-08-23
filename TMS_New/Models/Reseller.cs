namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reseller")]
    public partial class Reseller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reseller()
        {
            Subscribers = new HashSet<Subscriber>();
        }

        public Guid ID { get; set; }

        public Guid country { get; set; }

        [Required]
        [StringLength(4000)]
        public string address { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string fax { get; set; }

        [Required]
        [StringLength(320)]
        public string website { get; set; }

        public Guid? currency { get; set; }

        [StringLength(4000)]
        public string trainingDescription { get; set; }

        [StringLength(100)]
        public string territory { get; set; }

        [StringLength(4000)]
        public string comment { get; set; }

        public Guid contactPerson { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        public Guid distributor { get; set; }

        public Guid language { get; set; }

        public Guid paymentTerm { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int label { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual ContactPerson ContactPerson1 { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Currency Currency1 { get; set; }

        public virtual Distributor Distributor1 { get; set; }

        public virtual Language Language1 { get; set; }

        public virtual PaymentTerm PaymentTerm1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
