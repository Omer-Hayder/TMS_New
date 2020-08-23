namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ContractType()
        {
            NWC_Contract = new HashSet<NWC_Contract>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(500)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string NameEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Contract> NWC_Contract { get; set; }
    }
}
