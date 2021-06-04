﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class AssigmentInformation
    {
        public AssigmentInformation()
        {
            ImmigrationProfiles = new HashSet<ImmigrationProfile>();
        }

        public int Id { get; set; }
        public string LegalNameHomeCountry { get; set; }
        public string LocationHome { get; set; }
        public string CurrentJobPositionTitle { get; set; }
        public DateTime? EmploymentFrom { get; set; }
        public DateTime? EmploymentTo { get; set; }
        public string LegalNameHostCountry { get; set; }
        public string LocationHost { get; set; }
        public string NewJobPositionTitle { get; set; }
        public string NewJobResponsibilitie { get; set; }
        public DateTime? EstimatedStartDate { get; set; }
        public string LenghtAssigment { get; set; }
        public string CurrentGrossSalary { get; set; }
        public int? CurrencyCurrentGrossSalary { get; set; }
        public string NewGrossSalary { get; set; }
        public int? CurrencyNewGrossSalary { get; set; }
        public string PayrollLocation { get; set; }
        public string PayrollLocationSecond { get; set; }
        public bool? SplitPayrollApplicable { get; set; }
        public string HiringManager { get; set; }
        public string HiringManagerPhone { get; set; }
        public string HiringManagerEmail { get; set; }
        public string LegalRepresentative { get; set; }
        public string SpecificAtention { get; set; }
        public string DocumentType { get; set; }
        public string LicenseDriver { get; set; }

        public virtual CatCurrency CurrencyCurrentGrossSalaryNavigation { get; set; }
        public virtual CatCurrency CurrencyNewGrossSalaryNavigation { get; set; }
        public virtual ICollection<ImmigrationProfile> ImmigrationProfiles { get; set; }
    }
}