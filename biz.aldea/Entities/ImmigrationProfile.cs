﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ImmigrationProfile
    {
        public ImmigrationProfile()
        {
            DependentImmigrationInfos = new HashSet<DependentImmigrationInfo>();
            EducationalBackgrounds = new HashSet<EducationalBackground>();
            LenguageProficiencies = new HashSet<LenguageProficiency>();
        }

        public int Id { get; set; }
        public int? ServiceRecordId { get; set; }
        public int? PassportInformationId { get; set; }
        public int? PreviousHostCountryId { get; set; }
        public int? AssigmentInformationId { get; set; }
        public int? HighestLevelEducationalId { get; set; }

        public virtual AssigmentInformation AssigmentInformation { get; set; }
        public virtual CatHighestLevelEducation HighestLevelEducational { get; set; }
        public virtual PassportInformation PassportInformation { get; set; }
        public virtual PreviousHostCountry PreviousHostCountry { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
        public virtual ICollection<DependentImmigrationInfo> DependentImmigrationInfos { get; set; }
        public virtual ICollection<EducationalBackground> EducationalBackgrounds { get; set; }
        public virtual ICollection<LenguageProficiency> LenguageProficiencies { get; set; }
    }
}