namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderLog
    {
        public long ID { get; set; }

        public long WorkOrderId { get; set; }

        public int ActionLogTypeID { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? StatusID { get; set; }

        public string StatusComment { get; set; }

        public int? DeassignReasonID { get; set; }

        public int? OrderQuantity { get; set; }

        public long? CustomerLocationID { get; set; }

        public int? ServiceTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCost { get; set; }

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

        public DateTime? ScheduledDeliveryTime { get; set; }

        public DateTime? StatusTime { get; set; }

        public Guid? StationID { get; set; }

        public double? VehicleLatitude { get; set; }

        public double? VehicleLongitude { get; set; }

        [StringLength(20)]
        public string SourceApplication { get; set; }

        [StringLength(20)]
        public string CISDivision { get; set; }

        [StringLength(500)]
        public string TransactionID { get; set; }

        public int? StatusReasonId { get; set; }

        public long? CustomerAccountId { get; set; }

        public virtual NWC_ActionLogType NWC_ActionLogType { get; set; }

        public virtual NWC_DeassignReason NWC_DeassignReason { get; set; }

        public virtual NWC_StateWorkOrder NWC_StateWorkOrder { get; set; }

        public virtual TransporterStatu TransporterStatu { get; set; }
    }
}
