namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeOfBusiness")]
    public partial class TypeOfBusiness
    {
        public Guid id { get; set; }

        [StringLength(100)]
        public string name { get; set; }
    }
}
