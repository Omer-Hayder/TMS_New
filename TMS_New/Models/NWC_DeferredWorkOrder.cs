namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_DeferredWorkOrder
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ORDERNUMBER { get; set; }

        [StringLength(50)]
        public string CISDIVISION { get; set; }

        [StringLength(50)]
        public string COMMENT { get; set; }

        [StringLength(50)]
        public string CONFIRMATIONCODE { get; set; }

        [StringLength(50)]
        public string CONTACTMOBILE { get; set; }

        [StringLength(50)]
        public string CONTACTNAME { get; set; }

        [StringLength(50)]
        public string CREDTTM { get; set; }

        [StringLength(50)]
        public string SCHEDDTTM { get; set; }

        [StringLength(50)]
        public string SERVICETYPE { get; set; }

        [StringLength(50)]
        public string SOURCEAPPLICATION { get; set; }

        [StringLength(50)]
        public string TANKERSIZE { get; set; }

        [StringLength(50)]
        public string TRANSACTIONID { get; set; }

        [StringLength(50)]
        public string ACCOUNTID { get; set; }

        [StringLength(50)]
        public string CUSTOMERCLASS { get; set; }

        [StringLength(50)]
        public string MOBILENUMBER { get; set; }

        [StringLength(50)]
        public string PERSONID { get; set; }

        [StringLength(50)]
        public string PERSONIDTYPE { get; set; }

        [StringLength(50)]
        public string PERSONIDVALUE { get; set; }

        [StringLength(50)]
        public string PERSONPRIMARYNAME { get; set; }

        [StringLength(50)]
        public string PREMISEID { get; set; }

        [StringLength(50)]
        public string XYCOORDINATESGF { get; set; }

        public int? StatusId { get; set; }

        public string ErrorMSG { get; set; }

        public Guid? LastUpdatedBy { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public virtual NWC_DeferredWorkOrderStatus NWC_DeferredWorkOrderStatus { get; set; }
    }
}
