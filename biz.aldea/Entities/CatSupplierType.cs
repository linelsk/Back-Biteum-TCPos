﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatSupplierType
    {
        public CatSupplierType()
        {
            CatSupplierCompanies = new HashSet<CatSupplierCompany>();
            ConsultantContactsServices = new HashSet<ConsultantContactsService>();
            Coordinators = new HashSet<Coordinator>();
            ProfileUsers = new HashSet<ProfileUser>();
            SupplierPartnerProfileServices = new HashSet<SupplierPartnerProfileService>();
        }

        public int Id { get; set; }
        public string SupplierType { get; set; }
        public int? Type { get; set; }

        public virtual ICollection<CatSupplierCompany> CatSupplierCompanies { get; set; }
        public virtual ICollection<ConsultantContactsService> ConsultantContactsServices { get; set; }
        public virtual ICollection<Coordinator> Coordinators { get; set; }
        public virtual ICollection<ProfileUser> ProfileUsers { get; set; }
        public virtual ICollection<SupplierPartnerProfileService> SupplierPartnerProfileServices { get; set; }
    }
}