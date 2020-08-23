namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMailLogger")]
    public partial class DailyMailLogger
    {
        public Guid ID { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string MailContent { get; set; }

        public Guid UserId { get; set; }

        public DateTime LogDate { get; set; }

        public short MailType { get; set; }

        public bool IsSent { get; set; }

        public short NumberOfTrials { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime? ErrorMessageDate { get; set; }

        public DateTime? MailSendDate { get; set; }
    }
}
