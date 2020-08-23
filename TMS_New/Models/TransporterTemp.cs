namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterTemp")]
    public partial class TransporterTemp
    {
        public long? currentmileage1 { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string plateNo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string transporterTypeName { get; set; }

        public Guid? transporterType { get; set; }

        public Guid? branch { get; set; }

        public Guid? landmark { get; set; }

        [Key]
        [Column(Order = 4)]
        public double maxSpeed { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal literPerKm { get; set; }

        public long? currentMileage { get; set; }

        public string image { get; set; }

        public string color { get; set; }

        public Guid? transporterBrand { get; set; }

        public Guid? transporterProductionYear { get; set; }

        public Guid? transporterManufacturer { get; set; }

        public bool? deviceType { get; set; }

        [StringLength(100)]
        public string SIMCardNo { get; set; }

        [StringLength(100)]
        public string providerName { get; set; }

        [StringLength(25)]
        public string deviceCode { get; set; }

        [StringLength(100)]
        public string licenseNo { get; set; }

        public DateTime? licenseExpiryDate { get; set; }

        [StringLength(100)]
        public string chassisNo { get; set; }

        [StringLength(100)]
        public string engineNo { get; set; }

        public DateTime? entranceDate { get; set; }

        [StringLength(100)]
        public string insuranceNo { get; set; }

        [StringLength(100)]
        public string insuredBy { get; set; }

        public DateTime? insuranceStartDate { get; set; }

        public DateTime? insuranceEndDate { get; set; }

        public Guid? supplier { get; set; }

        public bool? isMonitored { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid SubID { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid CreatedBy { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        public string LisenceImage { get; set; }

        public int? status { get; set; }

        public double? HourRate { get; set; }

        public Guid? DeviceID { get; set; }

        public decimal? FuelCost { get; set; }

        public decimal? TempSensorMinValue { get; set; }

        public decimal? TempSensorMaxValue { get; set; }
    }
}
