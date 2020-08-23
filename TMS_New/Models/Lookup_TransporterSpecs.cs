namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lookup_TransporterSpecs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lookup_TransporterSpecs()
        {
            TransporterSpecs = new HashSet<TransporterSpec>();
        }

        public long Id { get; set; }

        public string NameEN { get; set; }

        public string NameAr { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsVisible { get; set; }

        public string UIClass { get; set; }

        public bool? IsNumeric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterSpec> TransporterSpecs { get; set; }
    }
}
