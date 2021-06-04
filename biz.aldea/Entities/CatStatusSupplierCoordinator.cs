﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatStatusSupplierCoordinator
    {
        public CatStatusSupplierCoordinator()
        {
            ImmigrationCoodinators = new HashSet<ImmigrationCoodinator>();
            ImmigrationSupplierPartners = new HashSet<ImmigrationSupplierPartner>();
            RelocationCoordinators = new HashSet<RelocationCoordinator>();
            RelocationSupplierPartners = new HashSet<RelocationSupplierPartner>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<ImmigrationCoodinator> ImmigrationCoodinators { get; set; }
        public virtual ICollection<ImmigrationSupplierPartner> ImmigrationSupplierPartners { get; set; }
        public virtual ICollection<RelocationCoordinator> RelocationCoordinators { get; set; }
        public virtual ICollection<RelocationSupplierPartner> RelocationSupplierPartners { get; set; }
    }
}