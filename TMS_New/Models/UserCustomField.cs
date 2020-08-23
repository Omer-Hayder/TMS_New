namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCustomField
    {
        [Key]
        public Guid UserId { get; set; }

        [StringLength(500)]
        public string TAMMUserName { get; set; }

        [StringLength(500)]
        public string TAMMPassword { get; set; }

        [StringLength(500)]
        public string ShomoosUserName { get; set; }

        [StringLength(500)]
        public string ShomoosPassword { get; set; }

        public bool? IsTAMMValidated { get; set; }

        public bool? IShomoosValidated { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}
