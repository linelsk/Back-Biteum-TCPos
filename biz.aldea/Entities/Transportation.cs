﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Transportation
    {
        public Transportation()
        {
            CommentTransportations = new HashSet<CommentTransportation>();
            DocumentTransportations = new HashSet<DocumentTransportation>();
            ExtensionTransportations = new HashSet<ExtensionTransportation>();
            FamilyMemberTransportations = new HashSet<FamilyMemberTransportation>();
            PaymentTransportations = new HashSet<PaymentTransportation>();
            ReminderTransportations = new HashSet<ReminderTransportation>();
        }

        public int Id { get; set; }
        public int WorkOrderServicesId { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public int? ApplicantId { get; set; }
        public bool? Coordination { get; set; }
        public int StatusId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public int? TotalTimeAllowed { get; set; }
        public int? TotalTimeAllowedId { get; set; }
        public decimal? Budget { get; set; }
        public string Comments { get; set; }
        public string ProjectFee { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? TransportType { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string TimeServicesHour { get; set; }
        public string TimeServicesMinute { get; set; }
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public int? SupplierPartner { get; set; }
        public string DriverName { get; set; }
        public string DriverContact { get; set; }
        public string Vehicle { get; set; }
        public string PlateNumber { get; set; }
        public string VehicleColor { get; set; }
        public bool? Pet { get; set; }

        public virtual CatStatusWorkOrder Status { get; set; }
        public virtual CatDuration TotalTimeAllowedNavigation { get; set; }
        public virtual WorkOrderService WorkOrderServices { get; set; }
        public virtual ICollection<CommentTransportation> CommentTransportations { get; set; }
        public virtual ICollection<DocumentTransportation> DocumentTransportations { get; set; }
        public virtual ICollection<ExtensionTransportation> ExtensionTransportations { get; set; }
        public virtual ICollection<FamilyMemberTransportation> FamilyMemberTransportations { get; set; }
        public virtual ICollection<PaymentTransportation> PaymentTransportations { get; set; }
        public virtual ICollection<ReminderTransportation> ReminderTransportations { get; set; }
    }
}