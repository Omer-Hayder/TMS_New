namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_Class()
        {
            SCO_Students = new HashSet<SCO_Students>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int GradeId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual SCO_Grade SCO_Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Students> SCO_Students { get; set; }
    }
}
