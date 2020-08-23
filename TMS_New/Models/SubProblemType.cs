namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubProblemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubProblemType()
        {
            SubProblemTypesNotifications = new HashSet<SubProblemTypesNotification>();
        }

        public Guid Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Describtion { get; set; }

        public int? DueEveryMiles { get; set; }

        public int? DueEveryday { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? Modificationdate { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? ProblemTypeId { get; set; }

        public int? Type { get; set; }

        public bool? IsDefault { get; set; }

        public virtual ProblemType ProblemType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProblemTypesNotification> SubProblemTypesNotifications { get; set; }
    }
}
