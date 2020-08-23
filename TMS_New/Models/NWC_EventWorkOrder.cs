namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_EventWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_EventWorkOrder()
        {
            NWC_WorkOrderAccessory = new HashSet<NWC_WorkOrderAccessory>();
        }

        [Key]
        public long EventOrderID { get; set; }

        public long? ParentWorkOrderID { get; set; }

        public long EventID { get; set; }

        [StringLength(20)]
        public string OrderNumber { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid CreatedBy { get; set; }

        public int StatusID { get; set; }

        public string StatusComment { get; set; }

        public int? StatusReasonID { get; set; }

        public int? DeassignReasonID { get; set; }

        public int? OrderQuantity { get; set; }

        public DateTime? ScheduledDeliveryTime { get; set; }

        public DateTime RequestTime { get; set; }

        public long? CustomerLocationID { get; set; }

        public int? ServiceTypeID { get; set; }

        public Guid? StationID { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string ConfirmationCode { get; set; }

        [StringLength(1000)]
        public string AccessoriesAr { get; set; }

        [StringLength(1000)]
        public string AccessoriesEn { get; set; }

        public decimal? Distance { get; set; }

        public Guid? VehicleID { get; set; }

        public Guid? DriverID { get; set; }

        public int? VehicleStatusID { get; set; }

        [StringLength(100)]
        public string RecieverName { get; set; }

        [StringLength(20)]
        public string RecieverMobile { get; set; }

        public string Comments { get; set; }

        public DateTime? StatusTime { get; set; }

        public double? VehicleLatitude { get; set; }

        public double? VehicleLongitude { get; set; }

        [StringLength(20)]
        public string SourceApplication { get; set; }

        [StringLength(20)]
        public string CISDivision { get; set; }

        [StringLength(500)]
        public string TransactionID { get; set; }

        public long? CustomerAccountId { get; set; }

        public virtual NWC_DeassignReason NWC_DeassignReason { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_WorkOrderAccessory> NWC_WorkOrderAccessory { get; set; }

        public virtual NWC_WorkOrderTransaction NWC_WorkOrderTransaction { get; set; }
    }
}
