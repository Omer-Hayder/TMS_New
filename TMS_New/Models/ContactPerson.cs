namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactPerson")]
    public partial class ContactPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactPerson()
        {
            Branches = new HashSet<Branch>();
            Distributors = new HashSet<Distributor>();
            Landmarks = new HashSet<Landmark>();
            Resellers = new HashSet<Reseller>();
            Subscribers = new HashSet<Subscriber>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(320)]
        public string email { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public Guid? SubId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> Branches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Distributor> Distributors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landmark> Landmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reseller> Resellers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
