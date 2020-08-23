namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContactPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ContactPerson()
        {
            NWC_Contractor = new HashSet<NWC_Contractor>();
            NWC_ContractStations = new HashSet<NWC_ContractStations>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string SecondName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(1000)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(10)]
        public string MobileCode { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(10)]
        public string LandlineNumbeCode { get; set; }

        [StringLength(20)]
        public string LandlineNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? PersonalIDType { get; set; }

        [StringLength(50)]
        public string PersonalIDNumber { get; set; }

        [StringLength(10)]
        public string PersonAddressPostalCode { get; set; }

        public string PersonAddress { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Contractor> NWC_Contractor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStations> NWC_ContractStations { get; set; }
    }
}
