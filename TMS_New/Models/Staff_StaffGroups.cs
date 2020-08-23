namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff_StaffGroups
    {
        [Key]
        [Column(Order = 0)]
        public Guid StaffID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid StaffGroupID { get; set; }

        public Guid? SubID { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual StaffGroup StaffGroup { get; set; }
    }
}
