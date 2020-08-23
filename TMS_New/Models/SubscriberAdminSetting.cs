namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberAdminSetting
    {
        [Key]
        public Guid SubID { get; set; }

        public string applicationLogo { get; set; }

        public string billingLogo { get; set; }

        [StringLength(4000)]
        public string billingFooter { get; set; }

        public bool? SMAlert { get; set; }

        public bool? MileageConflictAlert { get; set; }

        public bool? RFMWarning { get; set; }

        public bool? WOWarning { get; set; }

        public int? RFMWarningDays { get; set; }

        public int? WOWarningDays { get; set; }

        [StringLength(4000)]
        public string TimeZone { get; set; }

        public int? DefaultMap { get; set; }

        [StringLength(50)]
        public string Currancy { get; set; }

        public Guid? FK_Currency { get; set; }

        public bool? IsCostIntegration { get; set; }

        public bool? IsProjectBase { get; set; }

        [StringLength(20)]
        public string DefaultLanguage { get; set; }

        public int? MaxFailedPassword { get; set; }

        public int? MinPasswordLength { get; set; }

        public int? MaxPasswordAge { get; set; }

        public bool? IdleUseIgnitionIfExists { get; set; }

        public short? IdleTimeMinSettings { get; set; }

        public int? PasswordsHistoryNo { get; set; }

        public int? MinTimeForDisconnectedAlert { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
