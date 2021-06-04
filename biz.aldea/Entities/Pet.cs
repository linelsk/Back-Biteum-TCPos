﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class Pet
    {
        public int Id { get; set; }
        public int? PetTypeId { get; set; }
        public string Name { get; set; }
        public string BreedId { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? SizeId { get; set; }
        public decimal? Weight { get; set; }
        public int? WeightMeasuresId { get; set; }
        public int AssigneeInformationId { get; set; }
        public string Photo { get; set; }

        public virtual AssigneeInformation AssigneeInformation { get; set; }
        public virtual CatPetType PetType { get; set; }
        public virtual CatSize Size { get; set; }
        public virtual CatWeightMeasure WeightMeasures { get; set; }
    }
}