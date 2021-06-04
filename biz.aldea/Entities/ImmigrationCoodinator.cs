﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.premier.Entities
{
    public partial class ImmigrationCoodinator
    {
        public int Id { get; set; }
        public int? CoordinatorTypeId { get; set; }
        public int? CoordinatorId { get; set; }
        public DateTime? Assigned { get; set; }
        public DateTime? Accepted { get; set; }
        public int ServiceRecordId { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ProfileUser Coordinator { get; set; }
        public virtual CatCoordinatorType CoordinatorType { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
        public virtual CatStatusSupplierCoordinator Status { get; set; }
    }
}