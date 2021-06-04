﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace api.premier.Models.Transportation
{
    public class DocumentTransportationDto
    {
        public int Id { get; set; }
        public string FileRequest { get; set; }
        public string FileExtension { get; set; }
        public int? DocumentType { get; set; }
        public int? Relationship { get; set; }
        public int? Privacy { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string IssuingAuthority { get; set; }
        public int? CountryOrigin { get; set; }
        public string Comment { get; set; }
        public int? TransportationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        //public virtual CatCountry CountryOriginNavigation { get; set; }
        //public virtual CatDocumentType DocumentTypeNavigation { get; set; }
        //public virtual DependentInformation RelationshipNavigation { get; set; }
        public virtual TransportationDto Transportation { get; set; }
    }
}