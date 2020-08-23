namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationsProject")]
    public partial class OperationsProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationsProject()
        {
            OperationProjectLoads = new HashSet<OperationProjectLoad>();
            ProjectMailRecipients = new HashSet<ProjectMailRecipient>();
            ProjectWorkOrders = new HashSet<ProjectWorkOrder>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public Guid customerId { get; set; }

        public Guid? supervisorId { get; set; }

        public string repeatRule { get; set; }

        [StringLength(4000)]
        public string notes { get; set; }

        public Guid SubId { get; set; }

        public Guid? ContractId { get; set; }

        public double? otherExpenses { get; set; }

        public double? paymentAmount { get; set; }

        public int? paymentMethod { get; set; }

        public double? taxes { get; set; }

        public double? totalExpenses { get; set; }

        public double? totalRevenue { get; set; }

        public int? status { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public double? otherExpensesActual { get; set; }

        public double? paymentAmountActual { get; set; }

        public int? paymentMethodActual { get; set; }

        public double? taxesActual { get; set; }

        public double? totalExpensesActual { get; set; }

        public double? totalRevenueActual { get; set; }

        public double? std_Quantity { get; set; }

        public double? Rest_PerDay { get; set; }

        public double? STT { get; set; }

        public virtual OperationContract OperationContract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationProjectLoad> OperationProjectLoads { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMailRecipient> ProjectMailRecipients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectWorkOrder> ProjectWorkOrders { get; set; }
    }
}
