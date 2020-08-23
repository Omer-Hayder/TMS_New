namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_UserServicePermission
    {
        public long Id { get; set; }

        public Guid StaffId { get; set; }

        public int ServiceID { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual NWC_ServiceType NWC_ServiceType { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
