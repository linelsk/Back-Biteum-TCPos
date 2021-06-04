﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Invoice
    {
        public Invoice()
        {
            AdditionalExpenses = new HashSet<AdditionalExpense>();
            CommentInvoices = new HashSet<CommentInvoice>();
            DocumentInvoices = new HashSet<DocumentInvoice>();
            ServiceInvoices = new HashSet<ServiceInvoice>();
        }

        public int Id { get; set; }
        public int? ServiceRecord { get; set; }
        public int? InvoiceType { get; set; }
        public int? Consultant { get; set; }
        public string Comments { get; set; }
        public string InoviceNo { get; set; }
        public string PaymentNumber { get; set; }
        public int? MethodPayment { get; set; }
        public int? PaymentId { get; set; }
        public int? Office { get; set; }
        public int? Contact { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual OfficeContact ContactNavigation { get; set; }
        public virtual CatInvoiceType InvoiceTypeNavigation { get; set; }
        public virtual OfficeInformation OfficeNavigation { get; set; }
        public virtual ServiceRecord ServiceRecordNavigation { get; set; }
        public virtual ICollection<AdditionalExpense> AdditionalExpenses { get; set; }
        public virtual ICollection<CommentInvoice> CommentInvoices { get; set; }
        public virtual ICollection<DocumentInvoice> DocumentInvoices { get; set; }
        public virtual ICollection<ServiceInvoice> ServiceInvoices { get; set; }
    }
}