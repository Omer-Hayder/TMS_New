namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_CustomerAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_CustomerAccount()
        {
            NWC_SoqyaSchedules = new HashSet<NWC_SoqyaSchedules>();
            NWC_StateWorkOrder = new HashSet<NWC_StateWorkOrder>();
        }

        public long ID { get; set; }

        public long CustomerId { get; set; }

        public long CustomerLocationId { get; set; }

        public int ServiceTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountId_Integration { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? SoqyaBalance { get; set; }

        public DateTime? EligibleStartDate { get; set; }

        public DateTime? EligibleEndDate { get; set; }

        [StringLength(1000)]
        public string Note { get; set; }

        public virtual NWC_Customer NWC_Customer { get; set; }

        public virtual NWC_CustomerLocation NWC_CustomerLocation { get; set; }

        public virtual NWC_ServiceType NWC_ServiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_SoqyaSchedules> NWC_SoqyaSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StateWorkOrder> NWC_StateWorkOrder { get; set; }
    }
}
