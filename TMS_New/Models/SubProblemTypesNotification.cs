namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubProblemTypesNotification")]
    public partial class SubProblemTypesNotification
    {
        public Guid Id { get; set; }

        public int? NotificationEveryday { get; set; }

        public int? NotificationsEveryMiles { get; set; }

        public Guid? SubProblemTypeId { get; set; }

        public Guid? BranchId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual SubProblemType SubProblemType { get; set; }
    }
}
