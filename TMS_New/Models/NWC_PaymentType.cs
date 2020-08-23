namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_PaymentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_PaymentType()
        {
            NWC_CustomerLocationBalance = new HashSet<NWC_CustomerLocationBalance>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string TypeAr { get; set; }

        [StringLength(100)]
        public string TypeEn { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerLocationBalance> NWC_CustomerLocationBalance { get; set; }
    }
}
