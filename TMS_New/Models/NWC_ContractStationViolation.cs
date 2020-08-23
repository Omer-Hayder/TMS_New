namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractStationViolation
    {
        public long ID { get; set; }

        public Guid StationID { get; set; }

        public long TermsID { get; set; }

        public long ViolationPaymentStatusID { get; set; }

        public Guid? VehicleID { get; set; }

        public Guid? StaffID { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_ContractTerms NWC_ContractTerms { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
