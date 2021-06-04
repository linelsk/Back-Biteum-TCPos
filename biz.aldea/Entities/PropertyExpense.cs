﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class PropertyExpense
    {
        public int Id { get; set; }
        public int? ContractDetail { get; set; }
        public string Expense { get; set; }
        public decimal? Amount { get; set; }
        public int? Currency { get; set; }
        public int? Recurrence { get; set; }
        public bool? Included { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ContractDetail ContractDetailNavigation { get; set; }
        public virtual CatCurrency CurrencyNavigation { get; set; }
        public virtual CatDuration RecurrenceNavigation { get; set; }
    }
}