﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatOffice
    {
        public CatOffice()
        {
            CatTitles = new HashSet<CatTitle>();
            Offices = new HashSet<Office>();
            ProfileUsers = new HashSet<ProfileUser>();
            ServiceRecords = new HashSet<ServiceRecord>();
        }

        public int Id { get; set; }
        public string Office { get; set; }
        public string Image { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? Currency { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCity CityNavigation { get; set; }
        public virtual CatCountry CountryNavigation { get; set; }
        public virtual CatCurrency CurrencyNavigation { get; set; }
        public virtual ICollection<CatTitle> CatTitles { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<ProfileUser> ProfileUsers { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}