namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscriber")]
    public partial class Subscriber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscriber()
        {
            aspnet_Users = new HashSet<aspnet_Users>();
            FuelLogs = new HashSet<FuelLog>();
            InspectionDetails = new HashSet<InspectionDetail>();
            MappedIntegrationCosts = new HashSet<MappedIntegrationCost>();
            OperationCosts = new HashSet<OperationCost>();
            OperationWorkOrders = new HashSet<OperationWorkOrder>();
            OperationWorkOrders1 = new HashSet<OperationWorkOrder>();
            Projects = new HashSet<Project1>();
            SCO_DailyTrip = new HashSet<SCO_DailyTrip>();
            SCO_Grade = new HashSet<SCO_Grade>();
            SCO_Guardians = new HashSet<SCO_Guardians>();
            SCO_Plan = new HashSet<SCO_Plan>();
            SCO_PlannedTrip = new HashSet<SCO_PlannedTrip>();
            SCO_Students = new HashSet<SCO_Students>();
            SubscriberLogs = new HashSet<SubscriberLog>();
            SubscriberTopUps = new HashSet<SubscriberTopUp>();
            SubscriptionActivityLogs = new HashSet<SubscriptionActivityLog>();
            UserPasswords = new HashSet<UserPassword>();
            Wasl_CompanyRegistration = new HashSet<Wasl_CompanyRegistration>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        public string address { get; set; }

        public Guid? country { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string telephone2 { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(320)]
        public string email { get; set; }

        [StringLength(320)]
        public string website { get; set; }

        public byte? typeOfBusiness { get; set; }

        [StringLength(4000)]
        public string locationsOfOperations { get; set; }

        public Guid? contactPerson { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        public Guid? reseller { get; set; }

        public int currentFleetSize { get; set; }

        public int currentUserAccounts { get; set; }

        public Guid? offer { get; set; }

        public Guid? discount { get; set; }

        [Column(TypeName = "money")]
        public decimal currentCredit { get; set; }

        public byte? state { get; set; }

        public int? tmpFleetSize { get; set; }

        public int? tmpUserAccounts { get; set; }

        public Guid? tmpOffer { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int label { get; set; }

        public bool? isDeleted { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public int? SubType { get; set; }

        public string ReportName { get; set; }

        public DateTime? CustomerBillingStartDate { get; set; }

        public DateTime? SIMCardActivationDate { get; set; }

        public bool? IsPaymentExpired { get; set; }

        public Guid? ResellerId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_Users> aspnet_Users { get; set; }

        public virtual ContactPerson ContactPerson1 { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Discount Discount1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuelLog> FuelLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionDetail> InspectionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MappedIntegrationCost> MappedIntegrationCosts { get; set; }

        public virtual Offer Offer1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationCost> OperationCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrder> OperationWorkOrders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project1> Projects { get; set; }

        public virtual Reseller Reseller1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTrip> SCO_DailyTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Grade> SCO_Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Guardians> SCO_Guardians { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Plan> SCO_Plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Students> SCO_Students { get; set; }

        public virtual SubscriberAdminSetting SubscriberAdminSetting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberLog> SubscriberLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberTopUp> SubscriberTopUps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionActivityLog> SubscriptionActivityLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPassword> UserPasswords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wasl_CompanyRegistration> Wasl_CompanyRegistration { get; set; }
    }
}
