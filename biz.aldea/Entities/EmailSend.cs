﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class EmailSend
    {
        public int Id { get; set; }
        public int ServiceLineId { get; set; }
        public int? ServiceRecordId { get; set; }
        public int EmailId { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }

        public virtual CatEmailSend Email { get; set; }
        public virtual CatServiceLine ServiceLine { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
    }
}