namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_UnitType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_UnitType()
        {
            PS_LoadType = new HashSet<PS_LoadType>();
        }

        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? SubId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_LoadType> PS_LoadType { get; set; }
    }
}
