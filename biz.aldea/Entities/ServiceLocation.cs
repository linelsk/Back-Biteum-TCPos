﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ServiceLocation
    {
        public ServiceLocation()
        {
            ServiceLocationCountries = new HashSet<ServiceLocationCountry>();
        }

        public int Id { get; set; }
        public int IdClientPartnerProfile { get; set; }
        public int IdServiceLine { get; set; }
        public int IdService { get; set; }
        public string NickName { get; set; }

        public virtual ClientPartnerProfile IdClientPartnerProfileNavigation { get; set; }
        public virtual CatServiceLine IdServiceLineNavigation { get; set; }
        public virtual CatService IdServiceNavigation { get; set; }
        public virtual ICollection<ServiceLocationCountry> ServiceLocationCountries { get; set; }
    }
}