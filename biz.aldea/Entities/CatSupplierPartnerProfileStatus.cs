﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatSupplierPartnerProfileStatus
    {
        public CatSupplierPartnerProfileStatus()
        {
            SupplierPartnerProfileConsultants = new HashSet<SupplierPartnerProfileConsultant>();
            SupplierPartnerProfileServices = new HashSet<SupplierPartnerProfileService>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<SupplierPartnerProfileConsultant> SupplierPartnerProfileConsultants { get; set; }
        public virtual ICollection<SupplierPartnerProfileService> SupplierPartnerProfileServices { get; set; }
    }
}