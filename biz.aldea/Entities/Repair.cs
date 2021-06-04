﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Repair
    {
        public Repair()
        {
            DocumentRepairs = new HashSet<DocumentRepair>();
        }

        public int Id { get; set; }
        public int? HousingList { get; set; }
        public int? RepairType { get; set; }
        public int? SupplierPartner { get; set; }
        public DateTime? RepairStartDate { get; set; }
        public DateTime? RepairEndDate { get; set; }
        public int? TotalDays { get; set; }
        public decimal? TotalCostRepair { get; set; }
        public int? Currency { get; set; }
        public string Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatCurrency CurrencyNavigation { get; set; }
        public virtual HousingList HousingListNavigation { get; set; }
        public virtual CatRepairType RepairTypeNavigation { get; set; }
        public virtual ICollection<DocumentRepair> DocumentRepairs { get; set; }
    }
}