﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class SchoolingInformation
    {
        public SchoolingInformation()
        {
            LanguangeSpokenSchoolingInformations = new HashSet<LanguangeSpokenSchoolingInformation>();
        }

        public int Id { get; set; }
        public int? SchoolingSearchId { get; set; }
        public string Avatar { get; set; }
        public int? RelationshipId { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public DateTime? Birth { get; set; }
        public int? Age { get; set; }
        public int? Nationality { get; set; }
        public int? CurrentGrade { get; set; }
        public string Comments { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatGradeSchooling CurrentGradeNavigation { get; set; }
        public virtual CatCountry NationalityNavigation { get; set; }
        public virtual DependentInformation Relationship { get; set; }
        public virtual SchoolingSearch SchoolingSearch { get; set; }
        public virtual CatSex SexNavigation { get; set; }
        public virtual ICollection<LanguangeSpokenSchoolingInformation> LanguangeSpokenSchoolingInformations { get; set; }
    }
}