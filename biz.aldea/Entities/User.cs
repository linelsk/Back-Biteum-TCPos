﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class User
    {
        public User()
        {
            AssigneeInformations = new HashSet<AssigneeInformation>();
            CallAssistants = new HashSet<CallAssistant>();
            CallCalleNavigations = new HashSet<Call>();
            CallCallerNavigations = new HashSet<Call>();
            ChatImmigrationRelocations = new HashSet<ChatImmigrationRelocation>();
            ClientPartnerProfileExperienceTeams = new HashSet<ClientPartnerProfileExperienceTeam>();
            ClientPartnerProfiles = new HashSet<ClientPartnerProfile>();
            ColaboratorMembers = new HashSet<ColaboratorMember>();
            CommentAirportTransportationServices = new HashSet<CommentAirportTransportationService>();
            CommentAreaOrientations = new HashSet<CommentAreaOrientation>();
            CommentCorporateAssistances = new HashSet<CommentCorporateAssistance>();
            CommentDepartures = new HashSet<CommentDeparture>();
            CommentDocumentManagements = new HashSet<CommentDocumentManagement>();
            CommentHomeFindings = new HashSet<CommentHomeFinding>();
            CommentHomePurchases = new HashSet<CommentHomePurchase>();
            CommentHomeSales = new HashSet<CommentHomeSale>();
            CommentHousings = new HashSet<CommentHousing>();
            CommentInvoices = new HashSet<CommentInvoice>();
            CommentLeaseRenewals = new HashSet<CommentLeaseRenewal>();
            CommentLegalReviews = new HashSet<CommentLegalReview>();
            CommentLocalDocumentations = new HashSet<CommentLocalDocumentation>();
            CommentNotifications = new HashSet<CommentNotification>();
            CommentOthers = new HashSet<CommentOther>();
            CommentPaymentConcepts = new HashSet<CommentPaymentConcept>();
            CommentPredecisionOrientations = new HashSet<CommentPredecisionOrientation>();
            CommentPropertyManagements = new HashSet<CommentPropertyManagement>();
            CommentRenewals = new HashSet<CommentRenewal>();
            CommentRentalFurnitureCoordinations = new HashSet<CommentRentalFurnitureCoordination>();
            CommentReportAnEvents = new HashSet<CommentReportAnEvent>();
            CommentRequestPayments = new HashSet<CommentRequestPayment>();
            CommentResidencyPermits = new HashSet<CommentResidencyPermit>();
            CommentSchoolingSearches = new HashSet<CommentSchoolingSearch>();
            CommentSettlingIns = new HashSet<CommentSettlingIn>();
            CommentTemporaryHosuings = new HashSet<CommentTemporaryHosuing>();
            CommentTenancyManagements = new HashSet<CommentTenancyManagement>();
            CommentTransportations = new HashSet<CommentTransportation>();
            CommentVisaDeregistrations = new HashSet<CommentVisaDeregistration>();
            CommentsEntryVisas = new HashSet<CommentsEntryVisa>();
            CommentsWorkPermits = new HashSet<CommentsWorkPermit>();
            ConversationUserReciverNavigations = new HashSet<Conversation>();
            ConversationUserToNavigations = new HashSet<Conversation>();
            Coordinators = new HashSet<Coordinator>();
            CountryLeaders = new HashSet<CountryLeader>();
            Follows = new HashSet<Follow>();
            HousingStatusHistories = new HashSet<HousingStatusHistory>();
            Messages = new HashSet<Message>();
            NotificationSystemUserFromNavigations = new HashSet<NotificationSystem>();
            NotificationSystemUserToNavigations = new HashSet<NotificationSystem>();
            Participants = new HashSet<Participant>();
            PostIts = new HashSet<PostIt>();
            ProfileUsers = new HashSet<ProfileUser>();
            PropertyReports = new HashSet<PropertyReport>();
            ReportDays = new HashSet<ReportDay>();
            RequestInformations = new HashSet<RequestInformation>();
            ScalateCommentUserFroms = new HashSet<ScalateComment>();
            ScalateCommentUserTos = new HashSet<ScalateComment>();
            ScalateServiceUserFroms = new HashSet<ScalateService>();
            ScalateServiceUserTos = new HashSet<ScalateService>();
            TaskReplies = new HashSet<TaskReply>();
            TaskTaskFromNavigations = new HashSet<Task>();
            TaskTaskToNavigations = new HashSet<Task>();
            UserGroups = new HashSet<UserGroup>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MotherLastName { get; set; }
        public string MobilePhone { get; set; }
        public int RoleId { get; set; }
        public int? UserTypeId { get; set; }
        public int? ServiceLineId { get; set; }
        public string Avatar { get; set; }
        public bool? Reset { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Status { get; set; }
        public bool? Send { get; set; }
        public string FcmToken { get; set; }

        public virtual CatRole Role { get; set; }
        public virtual CatServiceLine ServiceLine { get; set; }
        public virtual CatUserType UserType { get; set; }
        public virtual ICollection<AssigneeInformation> AssigneeInformations { get; set; }
        public virtual ICollection<CallAssistant> CallAssistants { get; set; }
        public virtual ICollection<Call> CallCalleNavigations { get; set; }
        public virtual ICollection<Call> CallCallerNavigations { get; set; }
        public virtual ICollection<ChatImmigrationRelocation> ChatImmigrationRelocations { get; set; }
        public virtual ICollection<ClientPartnerProfileExperienceTeam> ClientPartnerProfileExperienceTeams { get; set; }
        public virtual ICollection<ClientPartnerProfile> ClientPartnerProfiles { get; set; }
        public virtual ICollection<ColaboratorMember> ColaboratorMembers { get; set; }
        public virtual ICollection<CommentAirportTransportationService> CommentAirportTransportationServices { get; set; }
        public virtual ICollection<CommentAreaOrientation> CommentAreaOrientations { get; set; }
        public virtual ICollection<CommentCorporateAssistance> CommentCorporateAssistances { get; set; }
        public virtual ICollection<CommentDeparture> CommentDepartures { get; set; }
        public virtual ICollection<CommentDocumentManagement> CommentDocumentManagements { get; set; }
        public virtual ICollection<CommentHomeFinding> CommentHomeFindings { get; set; }
        public virtual ICollection<CommentHomePurchase> CommentHomePurchases { get; set; }
        public virtual ICollection<CommentHomeSale> CommentHomeSales { get; set; }
        public virtual ICollection<CommentHousing> CommentHousings { get; set; }
        public virtual ICollection<CommentInvoice> CommentInvoices { get; set; }
        public virtual ICollection<CommentLeaseRenewal> CommentLeaseRenewals { get; set; }
        public virtual ICollection<CommentLegalReview> CommentLegalReviews { get; set; }
        public virtual ICollection<CommentLocalDocumentation> CommentLocalDocumentations { get; set; }
        public virtual ICollection<CommentNotification> CommentNotifications { get; set; }
        public virtual ICollection<CommentOther> CommentOthers { get; set; }
        public virtual ICollection<CommentPaymentConcept> CommentPaymentConcepts { get; set; }
        public virtual ICollection<CommentPredecisionOrientation> CommentPredecisionOrientations { get; set; }
        public virtual ICollection<CommentPropertyManagement> CommentPropertyManagements { get; set; }
        public virtual ICollection<CommentRenewal> CommentRenewals { get; set; }
        public virtual ICollection<CommentRentalFurnitureCoordination> CommentRentalFurnitureCoordinations { get; set; }
        public virtual ICollection<CommentReportAnEvent> CommentReportAnEvents { get; set; }
        public virtual ICollection<CommentRequestPayment> CommentRequestPayments { get; set; }
        public virtual ICollection<CommentResidencyPermit> CommentResidencyPermits { get; set; }
        public virtual ICollection<CommentSchoolingSearch> CommentSchoolingSearches { get; set; }
        public virtual ICollection<CommentSettlingIn> CommentSettlingIns { get; set; }
        public virtual ICollection<CommentTemporaryHosuing> CommentTemporaryHosuings { get; set; }
        public virtual ICollection<CommentTenancyManagement> CommentTenancyManagements { get; set; }
        public virtual ICollection<CommentTransportation> CommentTransportations { get; set; }
        public virtual ICollection<CommentVisaDeregistration> CommentVisaDeregistrations { get; set; }
        public virtual ICollection<CommentsEntryVisa> CommentsEntryVisas { get; set; }
        public virtual ICollection<CommentsWorkPermit> CommentsWorkPermits { get; set; }
        public virtual ICollection<Conversation> ConversationUserReciverNavigations { get; set; }
        public virtual ICollection<Conversation> ConversationUserToNavigations { get; set; }
        public virtual ICollection<Coordinator> Coordinators { get; set; }
        public virtual ICollection<CountryLeader> CountryLeaders { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<HousingStatusHistory> HousingStatusHistories { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<NotificationSystem> NotificationSystemUserFromNavigations { get; set; }
        public virtual ICollection<NotificationSystem> NotificationSystemUserToNavigations { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<PostIt> PostIts { get; set; }
        public virtual ICollection<ProfileUser> ProfileUsers { get; set; }
        public virtual ICollection<PropertyReport> PropertyReports { get; set; }
        public virtual ICollection<ReportDay> ReportDays { get; set; }
        public virtual ICollection<RequestInformation> RequestInformations { get; set; }
        public virtual ICollection<ScalateComment> ScalateCommentUserFroms { get; set; }
        public virtual ICollection<ScalateComment> ScalateCommentUserTos { get; set; }
        public virtual ICollection<ScalateService> ScalateServiceUserFroms { get; set; }
        public virtual ICollection<ScalateService> ScalateServiceUserTos { get; set; }
        public virtual ICollection<TaskReply> TaskReplies { get; set; }
        public virtual ICollection<Task> TaskTaskFromNavigations { get; set; }
        public virtual ICollection<Task> TaskTaskToNavigations { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}