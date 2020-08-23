namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wasl_CompanyRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wasl_CompanyRegistration()
        {
            Wasl_CompanyRegistration_Log = new HashSet<Wasl_CompanyRegistration_Log>();
        }

        public long ID { get; set; }

        public Guid SubscriberId { get; set; }

        [Required]
        [StringLength(50)]
        public string WaslReferenceKey { get; set; }

        [Required]
        [StringLength(50)]
        public string IdentityNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CommercialRecordNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CommercialRecordIssueDateHijri { get; set; }

        public DateTime CommercialRecordIssueDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string ExtensionNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string ManagerName { get; set; }

        [Required]
        [StringLength(15)]
        public string ManagerPhoneNumber { get; set; }

        [Required]
        [StringLength(15)]
        public string ManagerMobileNumber { get; set; }

        [StringLength(10)]
        public string ResultCode { get; set; }

        public DateTime? SyncDate { get; set; }

        public Guid? SyncBy { get; set; }

        public bool? Success { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wasl_CompanyRegistration_Log> Wasl_CompanyRegistration_Log { get; set; }
    }
}
