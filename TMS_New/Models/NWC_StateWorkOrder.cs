namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_StateWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_StateWorkOrder()
        {
            NWC_SoqyaSchedules = new HashSet<NWC_SoqyaSchedules>();
            NWC_WorkOrderComment = new HashSet<NWC_WorkOrderComment>();
            NWC_WorkOrderComplaint = new HashSet<NWC_WorkOrderComplaint>();
            NWC_WorkOrderLog = new HashSet<NWC_WorkOrderLog>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long WorkOrderId { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public int LastStatusID { get; set; }

        public Guid? LastStatusBy { get; set; }

        public DateTime? LastStatusTime { get; set; }

        public string LastStatusComment { get; set; }

        public string LastStatusReason { get; set; }

        public int OrderQuantity { get; set; }

        public DateTime ScheduledDeliveryTime { get; set; }

        public DateTime RequestTime { get; set; }

        public long? CustomerLocationID { get; set; }

        public int? ServiceTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCost { get; set; }

        [Column(TypeName = "money")]
        public decimal NetCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        [StringLength(50)]
        public string InvoiceNo { get; set; }

        public int? InvoiceStatusID { get; set; }

        public Guid AssignedStationID { get; set; }

        public bool? IsAssigned { get; set; }

        public Guid? AssignedVehicleID { get; set; }

        public Guid? AssignedDriverID { get; set; }

        public int? VehicleStatusID { get; set; }

        [StringLength(1000)]
        public string AccessoriesAr { get; set; }

        [StringLength(1000)]
        public string AccessoriesEn { get; set; }

        public decimal? Distance { get; set; }

        [StringLength(50)]
        public string ConfirmationCode { get; set; }

        [StringLength(50)]
        public string EncryptedConfirmationCode { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid SubID { get; set; }

        [StringLength(100)]
        public string RecieverName { get; set; }

        [StringLength(20)]
        public string RecieverMobile { get; set; }

        public string Comments { get; set; }

        public int? Retrials { get; set; }

        public DateTime? RetrialTime { get; set; }

        public int? AssignRetrials { get; set; }

        public DateTime? AssignRetrialTime { get; set; }

        public int? CancelRetrials { get; set; }

        public DateTime? CancelRetrialTime { get; set; }

        [StringLength(20)]
        public string SourceApplication { get; set; }

        [StringLength(20)]
        public string CISDivision { get; set; }

        [StringLength(500)]
        public string TransactionID { get; set; }

        public long? CustomerAccountId { get; set; }

        public virtual NWC_CustomerAccount NWC_CustomerAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_SoqyaSchedules> NWC_SoqyaSchedules { get; set; }

        public virtual NWC_WorkOrderInvoiceStatus NWC_WorkOrderInvoiceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderComment> NWC_WorkOrderComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderComplaint> NWC_WorkOrderComplaint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderLog> NWC_WorkOrderLog { get; set; }
    }
}
