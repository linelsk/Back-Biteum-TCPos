﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CommentTemporaryHosuing
    {
        public int Id { get; set; }
        public int? TemporaryHousingCoordinationId { get; set; }
        public string Reply { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TemporaryHousingCoordinaton TemporaryHousingCoordination { get; set; }
        public virtual User User { get; set; }
    }
}