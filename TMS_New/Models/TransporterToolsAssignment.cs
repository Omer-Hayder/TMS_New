namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterToolsAssignment")]
    public partial class TransporterToolsAssignment
    {
        public Guid ID { get; set; }

        public Guid? tool { get; set; }

        public Guid? transporter { get; set; }

        public virtual TransporterTool TransporterTool { get; set; }
    }
}
