﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class CatSize
    {
        public CatSize()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Size { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}