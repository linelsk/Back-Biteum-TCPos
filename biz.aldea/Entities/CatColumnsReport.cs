﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatColumnsReport
    {
        public CatColumnsReport()
        {
            Columns = new HashSet<Column>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }

        public virtual ICollection<Column> Columns { get; set; }
    }
}