﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class PropertyReport
    {
        public PropertyReport()
        {
            Attendees = new HashSet<Attendee>();
            KeyInventories = new HashSet<KeyInventory>();
            PropertyReportSections = new HashSet<PropertyReportSection>();
        }

        public int Id { get; set; }
        public int PropertyInspection { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? HousingList { get; set; }
        public string PropertyAddress { get; set; }
        public int? ZipCode { get; set; }
        public string Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual HousingList HousingListNavigation { get; set; }
        public virtual CatPropertyInspection PropertyInspectionNavigation { get; set; }
        public virtual ICollection<Attendee> Attendees { get; set; }
        public virtual ICollection<KeyInventory> KeyInventories { get; set; }
        public virtual ICollection<PropertyReportSection> PropertyReportSections { get; set; }
    }
}