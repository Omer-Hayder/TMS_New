namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractTerms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ContractTerms()
        {
            NWC_ContractStationViolation = new HashSet<NWC_ContractStationViolation>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Description { get; set; }

        public long? TermsCategoryID { get; set; }

        public long ContractID { get; set; }

        public Guid? StationID { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public bool? IsActive { get; set; }

        public decimal? TotalValue { get; set; }

        public int? TotalValueUnitId { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_Contract NWC_Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStationViolation> NWC_ContractStationViolation { get; set; }

        public virtual NWC_TermsCategory NWC_TermsCategory { get; set; }

        public virtual NWC_TermsValueUnits NWC_TermsValueUnits { get; set; }
    }
}
