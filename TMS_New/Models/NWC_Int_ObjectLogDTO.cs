namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Int_ObjectLogDTO
    {
        public long ID { get; set; }

        public long LogID { get; set; }

        public string DTO { get; set; }

        public virtual NWC_Int_ObjectLog NWC_Int_ObjectLog { get; set; }
    }
}
