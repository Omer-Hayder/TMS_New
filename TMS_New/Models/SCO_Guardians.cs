namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Guardians
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_Guardians()
        {
            SCO_GuardianAttachments = new HashSet<SCO_GuardianAttachments>();
            SCO_StudentGuardianRelation = new HashSet<SCO_StudentGuardianRelation>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string IdentityNumber { get; set; }

        public int IdentityTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FamilyName { get; set; }

        [Required]
        [StringLength(100)]
        public string MobileNumber1 { get; set; }

        [StringLength(100)]
        public string MobileNumber2 { get; set; }

        [StringLength(100)]
        public string LandLineNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Occupation { get; set; }

        [StringLength(100)]
        public string WorkNumber { get; set; }

        public string WorkAddress { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? UserId { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public DateTime? IdentityExpireDate { get; set; }

        public string Email { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        public Guid SubId { get; set; }

        public short? MailStatus { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual aspnet_Users aspnet_Users2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_GuardianAttachments> SCO_GuardianAttachments { get; set; }

        public virtual SCO_IdentityType SCO_IdentityType { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_StudentGuardianRelation> SCO_StudentGuardianRelation { get; set; }
    }
}
