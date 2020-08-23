namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wasl_VehicleRegistration_Log
    {
        public long Id { get; set; }

        public long? VehicleRegistration_ID { get; set; }

        [StringLength(50)]
        public string SequenceNumber { get; set; }

        [StringLength(50)]
        public string VehiclePlate_Number { get; set; }

        [StringLength(10)]
        public string VehiclePlate_rightLetter { get; set; }

        [StringLength(10)]
        public string VehiclePlate_middleLetter { get; set; }

        [StringLength(10)]
        public string VehiclePlate_leftLetter { get; set; }

        public int? plateType { get; set; }

        public DateTime? SyncDate { get; set; }

        public Guid? SyncBy { get; set; }

        public bool? success { get; set; }

        [StringLength(10)]
        public string resultCode { get; set; }

        public bool? result_isvalid { get; set; }

        public string result_rejectionReason { get; set; }

        public string result_referenceKey { get; set; }
    }
}
