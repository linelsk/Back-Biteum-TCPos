﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class PhotoWhereEat
    {
        public int Id { get; set; }
        public int IdWhereEat { get; set; }
        public string FileName { get; set; }
        public string FileRequest { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual CityWhereEat IdWhereEatNavigation { get; set; }
    }
}