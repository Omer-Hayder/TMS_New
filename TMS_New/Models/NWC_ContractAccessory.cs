namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractAccessory
    {
        public long ID { get; set; }

        public long ContractID { get; set; }

        public Guid StationID { get; set; }

        public int AccessoryID { get; set; }

        [Column(TypeName = "money")]
        public decimal Charge { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_Accessory NWC_Accessory { get; set; }

        public virtual NWC_Contract NWC_Contract { get; set; }
    }
}
