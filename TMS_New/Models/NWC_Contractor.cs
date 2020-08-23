namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Contractor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_Contractor()
        {
            NWC_Contract = new HashSet<NWC_Contract>();
            NWC_ContractorAttachment = new HashSet<NWC_ContractorAttachment>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(1000)]
        public string ContractorFullName { get; set; }

        [Required]
        [StringLength(50)]
        public string CommercialIDNumber { get; set; }

        [Required]
        [StringLength(15)]
        public string TaxNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string MOI { get; set; }

        [StringLength(10)]
        public string CompanyAddressPostalCode { get; set; }

        public string CompanyAddress { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid SubID { get; set; }

        public long? ContactPersonId { get; set; }

        public bool IsBlackListed { get; set; }

        public Guid CompanyAddressCityID { get; set; }

        public virtual NWC_ContactPerson NWC_ContactPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Contract> NWC_Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractorAttachment> NWC_ContractorAttachment { get; set; }
    }
}
