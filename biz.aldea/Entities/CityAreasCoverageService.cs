﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CityAreasCoverageService
    {
        public int AreasCoverageService { get; set; }
        public int City { get; set; }

        public virtual AreasCoverageService AreasCoverageServiceNavigation { get; set; }
        public virtual CatCity CityNavigation { get; set; }
    }
}