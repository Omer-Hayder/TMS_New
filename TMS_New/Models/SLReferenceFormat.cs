namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLReferenceFormat")]
    public partial class SLReferenceFormat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLReferenceFormat()
        {
            SystemSettings = new HashSet<SystemSetting>();
        }

        public int SLReferenceFormatID { get; set; }

        [Required]
        [StringLength(50)]
        public string SLReferenceFormatName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemSetting> SystemSettings { get; set; }
    }
}
