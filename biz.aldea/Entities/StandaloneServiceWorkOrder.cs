﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class StandaloneServiceWorkOrder
    {
        public int Id { get; set; }
        public string ServiceNumber { get; set; }
        public int? WorkOrderId { get; set; }
        public int? DeliveredTo { get; set; }
        public int? DeliveringIn { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceTypeId { get; set; }
        public string Location { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? Autho { get; set; }
        public DateTime? Acceptance { get; set; }
        public bool? Coordination { get; set; }
        public int? AuthoTime { get; set; }
        public string ProjectedFee { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? WorkOrderServiceId { get; set; }
        public bool? InvoiceSupplier { get; set; }
        public string BillingHour { get; set; }

        public virtual CatCategory Category { get; set; }
        public virtual DependentInformation DeliveredToNavigation { get; set; }
        public virtual CatCountry DeliveringInNavigation { get; set; }
        public virtual CatService Service { get; set; }
        public virtual CatTypeService ServiceType { get; set; }
        public virtual CatStatusWorkOrder Status { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual WorkOrderService WorkOrderService { get; set; }
    }
}