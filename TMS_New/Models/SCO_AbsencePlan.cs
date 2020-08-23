namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_AbsencePlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_AbsencePlan()
        {
            SCO_AbsencePlanStudent = new HashSet<SCO_AbsencePlanStudent>();
        }

        public long Id { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        public string Comment { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Isdeleted { get; set; }

        public string Name { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? StartDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_AbsencePlanStudent> SCO_AbsencePlanStudent { get; set; }
    }
}
