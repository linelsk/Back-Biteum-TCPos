﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class StatusCountryDocument
    {
        public StatusCountryDocument()
        {
            CountryDocuments = new HashSet<CountryDocument>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CountryDocument> CountryDocuments { get; set; }
    }
}