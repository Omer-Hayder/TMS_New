namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrderLocationHistoryAction
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
