﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ScalateComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int? ScalateServiceId { get; set; }
        public DateTime? Date { get; set; }
        public int? UserFromId { get; set; }
        public int? UserToId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ScalateService ScalateService { get; set; }
        public virtual User UserFrom { get; set; }
        public virtual User UserTo { get; set; }
    }
}