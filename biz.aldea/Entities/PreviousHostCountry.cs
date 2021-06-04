﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class PreviousHostCountry
    {
        public PreviousHostCountry()
        {
            ImmigrationProfiles = new HashSet<ImmigrationProfile>();
        }

        public bool? PriorHostCountryVisaIssued { get; set; }
        public int Id { get; set; }
        public string VisaNumber { get; set; }
        public DateTime? Issue { get; set; }
        public DateTime? Expiration { get; set; }
        public string IssuingAuthority { get; set; }
        public string PlaceIssue { get; set; }
        public int? VisaCategoryId { get; set; }
        public string IdAssignedNumber { get; set; }
        public string PositionEmployer { get; set; }
        public string PositionResponsabilities { get; set; }

        public virtual CatVisaCategory VisaCategory { get; set; }
        public virtual ICollection<ImmigrationProfile> ImmigrationProfiles { get; set; }
    }
}