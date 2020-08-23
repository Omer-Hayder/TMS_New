namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_Students()
        {
            SCO_AbsencePlanStudent = new HashSet<SCO_AbsencePlanStudent>();
            SCO_DailyTripStudents = new HashSet<SCO_DailyTripStudents>();
            SCO_Notifications = new HashSet<SCO_Notifications>();
            SCO_PlannedTripStudents = new HashSet<SCO_PlannedTripStudents>();
            SCO_POI = new HashSet<SCO_POI>();
            SCO_StudentAttachments = new HashSet<SCO_StudentAttachments>();
            SCO_StudentGuardianRelation = new HashSet<SCO_StudentGuardianRelation>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FamilyName { get; set; }

        public DateTime BirthOdDay { get; set; }

        public Guid BranchId { get; set; }

        public int GenderId { get; set; }

        public int GradeId { get; set; }

        public int ClassId { get; set; }

        [StringLength(100)]
        public string RFID { get; set; }

        public bool BusSubscription { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        public string Email { get; set; }

        public string ProfilePic { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? SubId { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_AbsencePlanStudent> SCO_AbsencePlanStudent { get; set; }

        public virtual SCO_Class SCO_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTripStudents> SCO_DailyTripStudents { get; set; }

        public virtual SCO_Gender SCO_Gender { get; set; }

        public virtual SCO_Grade SCO_Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Notifications> SCO_Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTripStudents> SCO_PlannedTripStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_POI> SCO_POI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_StudentAttachments> SCO_StudentAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_StudentGuardianRelation> SCO_StudentGuardianRelation { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
