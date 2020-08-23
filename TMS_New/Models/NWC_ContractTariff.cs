namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractTariff
    {
        public long ID { get; set; }

        public long ContractID { get; set; }

        public Guid StationID { get; set; }

        public long? ZoneID { get; set; }

        public int CustomerLocationClassID { get; set; }

        public int ServiceTypeID { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column(TypeName = "money")]
        public decimal CubicMeterCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal DistanceCharge { get; set; }

        public decimal AfterFirstKM { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsActive { get; set; }

        public int? TanckerCapacityId { get; set; }

        public long? DateFromHijri { get; set; }

        public long? DateToHijri { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_Contract NWC_Contract { get; set; }

        public virtual NWC_CustomerLocationClass NWC_CustomerLocationClass { get; set; }

        public virtual NWC_ServiceType NWC_ServiceType { get; set; }

        public virtual NWC_TanckerCapacity NWC_TanckerCapacity { get; set; }
    }
}
