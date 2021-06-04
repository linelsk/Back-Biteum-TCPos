﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class HomePurchase
    {
        public HomePurchase()
        {
            CommentHomePurchases = new HashSet<CommentHomePurchase>();
            DocumentHomePurchases = new HashSet<DocumentHomePurchase>();
            ReminderHomePurchases = new HashSet<ReminderHomePurchase>();
        }

        public int Id { get; set; }
        public int? WorkOrderServices { get; set; }
        public bool? Coordination { get; set; }
        public DateTime? AuthoDate { get; set; }
        public DateTime? AuthoAcceptanceDate { get; set; }
        public int? DeliverTo { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public decimal? PurchaseDesiredPrice { get; set; }
        public int? CurrencyPurchaseDesiredPriceId { get; set; }
        public decimal? PurchaseFinalPrice { get; set; }
        public int? CurrencyPurchaseFinalPriceId { get; set; }
        public int? PurchaseStatusId { get; set; }
        public string Comment { get; set; }
        public bool? RelatedSupplier { get; set; }
        public string Agency { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNo { get; set; }
        public int? PropertyCommission { get; set; }
        public decimal? CommissionAmount { get; set; }
        public int? CurrencyCommissionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCurrency CurrencyCommission { get; set; }
        public virtual CatCurrency CurrencyPurchaseDesiredPrice { get; set; }
        public virtual CatCurrency CurrencyPurchaseFinalPrice { get; set; }
        public virtual DependentInformation DeliverToNavigation { get; set; }
        public virtual CatStatusHomePurchase PurchaseStatus { get; set; }
        public virtual CatStatusWorkOrder Status { get; set; }
        public virtual WorkOrderService WorkOrderServicesNavigation { get; set; }
        public virtual ICollection<CommentHomePurchase> CommentHomePurchases { get; set; }
        public virtual ICollection<DocumentHomePurchase> DocumentHomePurchases { get; set; }
        public virtual ICollection<ReminderHomePurchase> ReminderHomePurchases { get; set; }
    }
}