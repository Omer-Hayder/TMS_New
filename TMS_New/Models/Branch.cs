namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branch()
        {
            Branch1 = new HashSet<Branch>();
            Landmarks = new HashSet<Landmark>();
            Maintenance_VendorBranch = new HashSet<Maintenance_VendorBranch>();
            NotificationConfiguration_SubBranch = new HashSet<NotificationConfiguration_SubBranch>();
            NWC_Zone = new HashSet<NWC_Zone>();
            PS_OperationWorkOrder = new HashSet<PS_OperationWorkOrder>();
            PS_OperationWorkOrder1 = new HashSet<PS_OperationWorkOrder>();
            PS_OperationWorkOrderCodeSerial = new HashSet<PS_OperationWorkOrderCodeSerial>();
            RequestForRepairs = new HashSet<RequestForRepair>();
            SCO_Plan = new HashSet<SCO_Plan>();
            SCO_Students = new HashSet<SCO_Students>();
            Staffs = new HashSet<Staff>();
            SubProblemTypesNotifications = new HashSet<SubProblemTypesNotification>();
            UserBranchPermissions = new HashSet<UserBranchPermission>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        public bool IsSubBranch { get; set; }

        public Guid? parentBranchId { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        [StringLength(4000)]
        public string address { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string telephone2 { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(320)]
        public string website { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        public Guid? contactPerson { get; set; }

        public bool? IsActive { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isPermenant { get; set; }

        [StringLength(50)]
        public string prefix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> Branch1 { get; set; }

        public virtual Branch Branch2 { get; set; }

        public virtual ContactPerson ContactPerson1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landmark> Landmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance_VendorBranch> Maintenance_VendorBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_SubBranch> NotificationConfiguration_SubBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_Zone> NWC_Zone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder> PS_OperationWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder> PS_OperationWorkOrder1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrderCodeSerial> PS_OperationWorkOrderCodeSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Plan> SCO_Plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Students> SCO_Students { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProblemTypesNotification> SubProblemTypesNotifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBranchPermission> UserBranchPermissions { get; set; }
    }
}
