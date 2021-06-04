﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.CorporateAssistance
{
    public class CorporateAssistanceDto
    {
        public int Id { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public int ApplicantId { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public int? WorkOrderServicesId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public int? HostCountryId { get; set; }
        public int? HostCityId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int? ConsularServiceId { get; set; }
        public DateTime? DocumentCollectionStartDate { get; set; }
        public DateTime? DocumentCollectionCompletionDate { get; set; }
        public DateTime? DocumentDeliveryDate { get; set; }
        public DateTime? ApplicationSubmissionDate { get; set; }
        public DateTime? DocumentExpirationDate { get; set; }
        public DateTime? ApplicationApprovalDate { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual ICollection<CommentCorporateAssistanceDto> CommentCorporateAssistances { get; set; }
        public virtual ICollection<DocumentCorporateAssistanceDto> DocumentCorporateAssistances { get; set; }
        public virtual ICollection<RemiderCorporateAssistanceDto> RemiderCorporateAssistances { get; set; }
    }
    public class CorporateAssistanceSelectDto
    {
        public int Id { get; set; }
        public DateTime AuthoDate { get; set; }
        public DateTime AuthoAcceptanceDate { get; set; }
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public string Relationship { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public int? WorkOrderServicesId { get; set; }
        public DateTime? ServiceCompletionDate { get; set; }
        public int? HostCountryId { get; set; }
        public int? HostCityId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int? ConsularServiceId { get; set; }
        public DateTime? DocumentCollectionStartDate { get; set; }
        public DateTime? DocumentCollectionCompletionDate { get; set; }
        public DateTime? DocumentDeliveryDate { get; set; }
        public DateTime? ApplicationSubmissionDate { get; set; }
        public DateTime? DocumentExpirationDate { get; set; }
        public DateTime? ApplicationApprovalDate { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual ICollection<CommentCorporateAssistanceSelectDto> CommentCorporateAssistances { get; set; }
        public virtual ICollection<DocumentCorporateAssistanceSelectDto> DocumentCorporateAssistances { get; set; }
        public virtual ICollection<RemiderCorporateAssistanceDto> RemiderCorporateAssistances { get; set; }
    }
}