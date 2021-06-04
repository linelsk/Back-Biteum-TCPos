﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatLanguage
    {
        public CatLanguage()
        {
            CatCountries = new HashSet<CatCountry>();
            LanguageDependentInformations = new HashSet<LanguageDependentInformation>();
            LanguagesConsultantContactsConsultants = new HashSet<LanguagesConsultantContactsConsultant>();
            LanguagesConsultantContactsServices = new HashSet<LanguagesConsultantContactsService>();
            LanguagesSpokenSchoolingAreaOrientations = new HashSet<LanguagesSpokenSchoolingAreaOrientation>();
            LanguangeSpokenSchoolingInformations = new HashSet<LanguangeSpokenSchoolingInformation>();
            LenguageProficiencies = new HashSet<LenguageProficiency>();
            Schoolings = new HashSet<Schooling>();
            SchoolsLists = new HashSet<SchoolsList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CatCountry> CatCountries { get; set; }
        public virtual ICollection<LanguageDependentInformation> LanguageDependentInformations { get; set; }
        public virtual ICollection<LanguagesConsultantContactsConsultant> LanguagesConsultantContactsConsultants { get; set; }
        public virtual ICollection<LanguagesConsultantContactsService> LanguagesConsultantContactsServices { get; set; }
        public virtual ICollection<LanguagesSpokenSchoolingAreaOrientation> LanguagesSpokenSchoolingAreaOrientations { get; set; }
        public virtual ICollection<LanguangeSpokenSchoolingInformation> LanguangeSpokenSchoolingInformations { get; set; }
        public virtual ICollection<LenguageProficiency> LenguageProficiencies { get; set; }
        public virtual ICollection<Schooling> Schoolings { get; set; }
        public virtual ICollection<SchoolsList> SchoolsLists { get; set; }
    }
}