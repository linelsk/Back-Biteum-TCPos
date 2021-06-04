﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ServiceRecord
    {
        public ServiceRecord()
        {
            Appointments = new HashSet<Appointment>();
            AssigneeInformations = new HashSet<AssigneeInformation>();
            Calls = new HashSet<Call>();
            ChatConversationImmigrationRelocations = new HashSet<ChatConversationImmigrationRelocation>();
            EmailSends = new HashSet<EmailSend>();
            EmailServiceRecords = new HashSet<EmailServiceRecord>();
            ExperienceSurveys = new HashSet<ExperienceSurvey>();
            Follows = new HashSet<Follow>();
            ImmigrationCoodinators = new HashSet<ImmigrationCoodinator>();
            ImmigrationProfiles = new HashSet<ImmigrationProfile>();
            ImmigrationSupplierPartners = new HashSet<ImmigrationSupplierPartner>();
            Invoices = new HashSet<Invoice>();
            MapIts = new HashSet<MapIt>();
            NotificationSystems = new HashSet<NotificationSystem>();
            RelocationCoordinators = new HashSet<RelocationCoordinator>();
            RelocationSupplierPartners = new HashSet<RelocationSupplierPartner>();
            RequestInformations = new HashSet<RequestInformation>();
            Tasks = new HashSet<Task>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string NumberServiceRecord { get; set; }
        public DateTime InitialAutho { get; set; }
        public DateTime InithialAuthoAcceptance { get; set; }
        public int PartnerId { get; set; }
        public int ClientId { get; set; }
        public string ClientFileNumber { get; set; }
        public int? AuthorizedByImmigration { get; set; }
        public int? AuthorizedByRelocation { get; set; }
        public bool? CopyOnEmailImmigration { get; set; }
        public bool? CopyOnEmailRelocation { get; set; }
        public bool? SpocImmigration { get; set; }
        public bool? SpocRelocation { get; set; }
        public bool? Vip { get; set; }
        public bool? Urgent { get; set; }
        public bool? ConfidentialMove { get; set; }
        public string SpecialIntructions { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? Office { get; set; }
        public bool? ImmigrationClosed { get; set; }
        public bool? RelocationClosed { get; set; }
        public bool? ImmigrationCompleteReport { get; set; }
        public bool? RelocationCompleteReport { get; set; }

        public virtual OfficeContact AuthorizedByImmigrationNavigation { get; set; }
        public virtual OfficeContact AuthorizedByRelocationNavigation { get; set; }
        public virtual ClientPartnerProfile Client { get; set; }
        public virtual CatOffice OfficeNavigation { get; set; }
        public virtual ClientPartnerProfile Partner { get; set; }
        public virtual CatStatus Status { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<AssigneeInformation> AssigneeInformations { get; set; }
        public virtual ICollection<Call> Calls { get; set; }
        public virtual ICollection<ChatConversationImmigrationRelocation> ChatConversationImmigrationRelocations { get; set; }
        public virtual ICollection<EmailSend> EmailSends { get; set; }
        public virtual ICollection<EmailServiceRecord> EmailServiceRecords { get; set; }
        public virtual ICollection<ExperienceSurvey> ExperienceSurveys { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<ImmigrationCoodinator> ImmigrationCoodinators { get; set; }
        public virtual ICollection<ImmigrationProfile> ImmigrationProfiles { get; set; }
        public virtual ICollection<ImmigrationSupplierPartner> ImmigrationSupplierPartners { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<MapIt> MapIts { get; set; }
        public virtual ICollection<NotificationSystem> NotificationSystems { get; set; }
        public virtual ICollection<RelocationCoordinator> RelocationCoordinators { get; set; }
        public virtual ICollection<RelocationSupplierPartner> RelocationSupplierPartners { get; set; }
        public virtual ICollection<RequestInformation> RequestInformations { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}