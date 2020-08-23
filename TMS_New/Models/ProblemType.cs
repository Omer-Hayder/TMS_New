namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProblemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProblemType()
        {
            MaintenancePMTasks = new HashSet<MaintenancePMTask>();
            Problems = new HashSet<Problem>();
            SubProblemTypes = new HashSet<SubProblemType>();
        }

        public Guid ID { get; set; }

        [StringLength(250)]
        public string problemName { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? IsAccident { get; set; }

        public bool? IsPM { get; set; }

        public DateTime? Modificationdate { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsSpareParts { get; set; }

        public int? ProblemCatId { get; set; }

        public long? DefaultSLADuration { get; set; }

        public int? DefaultSLADurationType { get; set; }

        public string UniqueKey { get; set; }

        public bool? DisableDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePMTask> MaintenancePMTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems { get; set; }

        public virtual ProblemCategory ProblemCategory { get; set; }

        public virtual SLADurationType SLADurationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProblemType> SubProblemTypes { get; set; }
    }
}
