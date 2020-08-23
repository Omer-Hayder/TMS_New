namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_Contract()
        {
            NWC_ContractAccessory = new HashSet<NWC_ContractAccessory>();
            NWC_ContractAttachment = new HashSet<NWC_ContractAttachment>();
            NWC_ContractPrice = new HashSet<NWC_ContractPrice>();
            NWC_ContractStations = new HashSet<NWC_ContractStations>();
            NWC_ContractTariff = new HashSet<NWC_ContractTariff>();
            NWC_ContractTerms = new HashSet<NWC_ContractTerms>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime ContractStartDate { get; set; }

        public DateTime ContractEndDate { get; set; }

        public DateTime? StatusChangedDate { get; set; }

        public DateTime? TerminatedDate { get; set; }

        public int? TerminationReasonID { get; set; }

        public long ContractorID { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ContractStatusID { get; set; }

        public int? ContractTypeID { get; set; }

        public Guid SubID { get; set; }

        [StringLength(24)]
        public string ConfirmationNo { get; set; }

        [StringLength(24)]
        public string AwardLetterNo { get; set; }

        public virtual NWC_Contractor NWC_Contractor { get; set; }

        public virtual NWC_ContractStatus NWC_ContractStatus { get; set; }

        public virtual NWC_ContractTerminationReason NWC_ContractTerminationReason { get; set; }

        public virtual NWC_ContractType NWC_ContractType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractAccessory> NWC_ContractAccessory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractAttachment> NWC_ContractAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractPrice> NWC_ContractPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStations> NWC_ContractStations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTariff> NWC_ContractTariff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTerms> NWC_ContractTerms { get; set; }
    }
}
