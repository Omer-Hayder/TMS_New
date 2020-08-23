namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_CustomerLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_CustomerLocation()
        {
            NWC_CustomerAccount = new HashSet<NWC_CustomerAccount>();
            NWC_CustomerLocationBalance = new HashSet<NWC_CustomerLocationBalance>();
        }

        public long ID { get; set; }

        public long CustomerID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        public long ZoneID { get; set; }

        public int ClassID { get; set; }

        public int PriorityID { get; set; }

        public int CategoryID { get; set; }

        public int StatusID { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string Address { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string Village { get; set; }

        [StringLength(20)]
        public string Center { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerAccount> NWC_CustomerAccount { get; set; }

        public virtual NWC_CustomerLocationCategory NWC_CustomerLocationCategory { get; set; }

        public virtual NWC_CustomerLocationClass NWC_CustomerLocationClass { get; set; }

        public virtual NWC_CustomerLocationPriority NWC_CustomerLocationPriority { get; set; }

        public virtual NWC_CustomerLocationStatus NWC_CustomerLocationStatus { get; set; }

        public virtual NWC_Zone NWC_Zone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerLocationBalance> NWC_CustomerLocationBalance { get; set; }
    }
}
