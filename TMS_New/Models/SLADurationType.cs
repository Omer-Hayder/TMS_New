namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLADurationType")]
    public partial class SLADurationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLADurationType()
        {
            Problems = new HashSet<Problem>();
            Problems1 = new HashSet<Problem>();
            ProblemTypes = new HashSet<ProblemType>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? ConvertToMin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProblemType> ProblemTypes { get; set; }

        public virtual SLADurationType SLADurationType1 { get; set; }

        public virtual SLADurationType SLADurationType2 { get; set; }
    }
}
