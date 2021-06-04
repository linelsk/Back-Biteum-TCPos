﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatRelationship
    {
        public CatRelationship()
        {
            Attendees = new HashSet<Attendee>();
            DependentInformations = new HashSet<DependentInformation>();
            EmergencyContacts = new HashSet<EmergencyContact>();
        }

        public int Id { get; set; }
        public string Relationship { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Attendee> Attendees { get; set; }
        public virtual ICollection<DependentInformation> DependentInformations { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
    }
}