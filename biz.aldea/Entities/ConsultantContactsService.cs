﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ConsultantContactsService
    {
        public ConsultantContactsService()
        {
            DocumentConsultantContactsServices = new HashSet<DocumentConsultantContactsService>();
            DocumentManagements = new HashSet<DocumentManagement>();
            HomeFindings = new HashSet<HomeFinding>();
            HousingLists = new HashSet<HousingList>();
            LanguagesConsultantContactsServices = new HashSet<LanguagesConsultantContactsService>();
            LocalDocumentations = new HashSet<LocalDocumentation>();
            Payments = new HashSet<Payment>();
            TemporaryHousingCoordinatons = new HashSet<TemporaryHousingCoordinaton>();
            VehicleServices = new HashSet<VehicleService>();
        }

        public int Id { get; set; }
        public int? AreasCoverage { get; set; }
        public string Photo { get; set; }
        public int? SupplierType { get; set; }
        public bool? Immigration { get; set; }
        public bool? Relocation { get; set; }
        public string ContactName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? City { get; set; }
        public string Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual AreasCoverageService AreasCoverageNavigation { get; set; }
        public virtual CatCity CityNavigation { get; set; }
        public virtual CatSupplierType SupplierTypeNavigation { get; set; }
        public virtual ICollection<DocumentConsultantContactsService> DocumentConsultantContactsServices { get; set; }
        public virtual ICollection<DocumentManagement> DocumentManagements { get; set; }
        public virtual ICollection<HomeFinding> HomeFindings { get; set; }
        public virtual ICollection<HousingList> HousingLists { get; set; }
        public virtual ICollection<LanguagesConsultantContactsService> LanguagesConsultantContactsServices { get; set; }
        public virtual ICollection<LocalDocumentation> LocalDocumentations { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<TemporaryHousingCoordinaton> TemporaryHousingCoordinatons { get; set; }
        public virtual ICollection<VehicleService> VehicleServices { get; set; }
    }
}