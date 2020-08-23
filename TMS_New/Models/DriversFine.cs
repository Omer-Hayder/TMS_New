namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DriversFine")]
    public partial class DriversFine
    {
        [StringLength(50)]
        public string FineType { get; set; }

        [StringLength(50)]
        public string FineAmount { get; set; }

        [StringLength(50)]
        public string FineAuthority { get; set; }

        [StringLength(50)]
        public string FineLocation { get; set; }

        [StringLength(50)]
        public string FineDescription { get; set; }

        public DateTime? FineDate { get; set; }

        public Guid? VehicleID { get; set; }

        public Guid? StaffID { get; set; }

        public Guid Id { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid SubId { get; set; }

        [StringLength(250)]
        public string ViolationNumber { get; set; }

        [StringLength(250)]
        public string ReceiptNumber { get; set; }

        [StringLength(250)]
        public string Source { get; set; }

        [StringLength(250)]
        public string ListNumber { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
