﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Column
    {
        public int Id { get; set; }
        public int? Report { get; set; }
        public int? Columns { get; set; }
        public int? Orden { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatColumnsReport ColumnsNavigation { get; set; }
        public virtual Report ReportNavigation { get; set; }
    }
}