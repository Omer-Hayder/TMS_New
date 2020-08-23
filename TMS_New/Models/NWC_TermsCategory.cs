namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_TermsCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_TermsCategory()
        {
            NWC_ContractTerms = new HashSet<NWC_ContractTerms>();
        }

        public long ID { get; set; }

        [StringLength(500)]
        public string CategoryAr { get; set; }

        [StringLength(500)]
        public string CategoryEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTerms> NWC_ContractTerms { get; set; }
    }
}
