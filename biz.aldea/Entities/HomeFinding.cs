﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class HomeFinding
    {
        public HomeFinding()
        {
            CommentHomeFindings = new HashSet<CommentHomeFinding>();
            CostSavings = new HashSet<CostSaving>();
            DocumentHomeFindings = new HashSet<DocumentHomeFinding>();
            ExtensionHomeFindings = new HashSet<ExtensionHomeFinding>();
            ReminderHomeFindings = new HashSet<ReminderHomeFinding>();
        }

        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public bool? Coordination { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public int? LeaseGuarentee { get; set; }
        public int? LeaseSignator { get; set; }
        public int? LeaseTemplate { get; set; }
        public bool? ClientSecurityInspectionRequired { get; set; }
        public decimal? PurchaseDesiredPrice { get; set; }
        public int? CurrencyPurchaseDesiredPrice { get; set; }
        public decimal? PurchaseFinalPrice { get; set; }
        public int? CurrencyPurchaseFinalPrice { get; set; }
        public int? PurchaseStatus { get; set; }
        public string Comment { get; set; }
        public bool? RelatedSupplier { get; set; }
        public int? SupplierPartner { get; set; }
        public int? Realtor { get; set; }
        public string CommentRelatedSupplier { get; set; }
        public string PropertComission { get; set; }
        public decimal? ComissionAmount { get; set; }
        public int? ComissionCurrency { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCurrency ComissionCurrencyNavigation { get; set; }
        public virtual CatCurrency CurrencyPurchaseDesiredPriceNavigation { get; set; }
        public virtual CatCurrency CurrencyPurchaseFinalPriceNavigation { get; set; }
        public virtual CatLeaseGuarantee LeaseGuarenteeNavigation { get; set; }
        public virtual DependentInformation LeaseSignatorNavigation { get; set; }
        public virtual CatLeaseTemplate LeaseTemplateNavigation { get; set; }
        public virtual CatPurchaseStatus PurchaseStatusNavigation { get; set; }
        public virtual ConsultantContactsService RealtorNavigation { get; set; }
        public virtual CatStatusWorkOrder Status { get; set; }
        public virtual SupplierPartnerProfileService SupplierPartnerNavigation { get; set; }
        public virtual WorkOrderService WorkOrderServices { get; set; }
        public virtual ICollection<CommentHomeFinding> CommentHomeFindings { get; set; }
        public virtual ICollection<CostSaving> CostSavings { get; set; }
        public virtual ICollection<DocumentHomeFinding> DocumentHomeFindings { get; set; }
        public virtual ICollection<ExtensionHomeFinding> ExtensionHomeFindings { get; set; }
        public virtual ICollection<ReminderHomeFinding> ReminderHomeFindings { get; set; }
    }
}