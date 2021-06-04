﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class AreasCoverageConsultant
    {
        public AreasCoverageConsultant()
        {
            AdministrativeContactsConsultants = new HashSet<AdministrativeContactsConsultant>();
            CityAreasCoverageConsultants = new HashSet<CityAreasCoverageConsultant>();
            DocumentAreasCoverageConsultants = new HashSet<DocumentAreasCoverageConsultant>();
            PaymentInformationConsultants = new HashSet<PaymentInformationConsultant>();
            ProfileUsers = new HashSet<ProfileUser>();
        }

        public int Id { get; set; }
        public int? SupplierPartnerProfileConsultant { get; set; }
        public int? Type { get; set; }
        public int? Country { get; set; }
        public int? PrimaryCity { get; set; }
        public string CurrentAddress { get; set; }
        public string ZipCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCountry CountryNavigation { get; set; }
        public virtual CatCity PrimaryCityNavigation { get; set; }
        public virtual SupplierPartnerProfileConsultant SupplierPartnerProfileConsultantNavigation { get; set; }
        public virtual CatAreaCoverageType TypeNavigation { get; set; }
        public virtual ICollection<AdministrativeContactsConsultant> AdministrativeContactsConsultants { get; set; }
        public virtual ICollection<CityAreasCoverageConsultant> CityAreasCoverageConsultants { get; set; }
        public virtual ICollection<DocumentAreasCoverageConsultant> DocumentAreasCoverageConsultants { get; set; }
        public virtual ICollection<PaymentInformationConsultant> PaymentInformationConsultants { get; set; }
        public virtual ICollection<ProfileUser> ProfileUsers { get; set; }
    }
}