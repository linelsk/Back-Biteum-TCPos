﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatSchoolStatus
    {
        public CatSchoolStatus()
        {
            SchoolsLists = new HashSet<SchoolsList>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<SchoolsList> SchoolsLists { get; set; }
    }
}