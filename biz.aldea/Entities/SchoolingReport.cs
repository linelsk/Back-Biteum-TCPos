﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class SchoolingReport
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? WorkOrder { get; set; }
        public int? ServiceId { get; set; }
        public int? Dependent { get; set; }
        public int? SchoolsList { get; set; }
        public string ReportDetails { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual DependentInformation DependentNavigation { get; set; }
        public virtual SchoolsList SchoolsListNavigation { get; set; }
    }
}