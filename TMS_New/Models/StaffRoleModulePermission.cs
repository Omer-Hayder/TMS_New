namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StaffRoleModulePermission
    {
        public Guid ID { get; set; }

        public Guid? StaffRoleID { get; set; }

        public Guid? AspNetRoleID { get; set; }

        public Guid? ModuleID { get; set; }

        public Guid? PageID { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual aspnet_Roles aspnet_Roles { get; set; }

        public virtual Module1 Module { get; set; }

        public virtual Page Page { get; set; }

        public virtual StaffRole StaffRole { get; set; }
    }
}
