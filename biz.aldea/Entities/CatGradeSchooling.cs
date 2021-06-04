﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatGradeSchooling
    {
        public CatGradeSchooling()
        {
            SchoolingAreaOrientations = new HashSet<SchoolingAreaOrientation>();
            SchoolingInformations = new HashSet<SchoolingInformation>();
            Schoolings = new HashSet<Schooling>();
            SchoolsLists = new HashSet<SchoolsList>();
        }

        public int Id { get; set; }
        public string Grade { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<SchoolingAreaOrientation> SchoolingAreaOrientations { get; set; }
        public virtual ICollection<SchoolingInformation> SchoolingInformations { get; set; }
        public virtual ICollection<Schooling> Schoolings { get; set; }
        public virtual ICollection<SchoolsList> SchoolsLists { get; set; }
    }
}