namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttachedFile")]
    public partial class AttachedFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttachedFile()
        {
            CheckInOutTransaction_AttachedFile = new HashSet<CheckInOutTransaction_AttachedFile>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string AttachName { get; set; }

        public string AttachPath { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? CreatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOutTransaction_AttachedFile> CheckInOutTransaction_AttachedFile { get; set; }
    }
}
